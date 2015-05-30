using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.IO;
using System.Web.Script.Serialization;


namespace WebAutoJ
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service1.svc или Service1.svc.cs в обозревателе решений и начните отладку.
    public class Service1 : IService1
    {

        public List<wsUser> GetAllUsers()
        {
            DriversSN_DBClassesDataContext dc = new DriversSN_DBClassesDataContext();
            List<wsUser> results = new List<wsUser>();

            foreach (Userr cust in dc.Userr)
            {
                results.Add(new wsUser()
                    {
                        UserID = cust.UserrID,
                        Name = cust.Name,
                        Login = cust.Login
                    });
            }

            return results;
        }

        public List<wsCar> GetCarsForCarOwner(string carOwnerID)
        {
            Entities dc = new Entities();
            dc.Database.SqlQuery<>();
            // System.Globalization.CultureInfo ci = System.Globalization.CultureInfo.GetCultureInfo("en-US");
            int OwnerID = Convert.ToInt32(carOwnerID);

            return dc.Car.Where(s => s.CarOwnerId == OwnerID).Select(car => new wsCar()
                {
                    CarID = car.CarID,
                    RegNumber = car.RegNumber,
                    Brand = car.Brand,
                    //CarOwner = car.CarOwnerId,
                    Color = car.Color,
                    Country = car.Country,
                    Model = car.Model
                }).ToList();
        }

        public List<wsMessage> GetMessagesForPeriod(string userid, string start, string end)
        {
            List<wsMessage> results = new List<wsMessage>();
            DriversSN_DBClassesDataContext dc = new DriversSN_DBClassesDataContext();
            int UserId = Convert.ToInt32(userid);
            DateTime Start = Convert.ToDateTime(start);
            DateTime End = Convert.ToDateTime(end);
            //dc.SearchMessages(UserId, Start, End);

            foreach (SearchMessagesResult message in dc.SearchMessages(UserId, Start, End))
            {
                results.Add(new wsMessage());
                {
                   // UserId = message.UserrID;
                    
                    /*UserID = message.UserrID,
                    MsgText = message.MessageText,
                    MsgPhoto = message.MsgPhoto,
                        GPS =message.GPSCoordinates,
                    CarRegNumber=message.CarRegNumber,
                        Viewed=message.Viewed,
                    Score=message.Score,
                        DateCreated=message.DateCreated*/
                };
            }

            return results;
        }

        /*  public void Register(string userid,string name,string  login,string password,string avatar, string email, string sn_id,
            string fld, string ms,string job,string birthdate,string gender,string hair,
            string carid,string regnumber,string country, string brand,string model,string color)
        {
            DriversSN_DBClassesDataContext dc = new DriversSN_DBClassesDataContext();
            int UserId = Convert.ToInt32(userid);
            int CarId = Convert.ToInt32(carid);
            int Sn_Id = Convert.ToInt32(sn_id);
            DateTime Fld = Convert.ToDateTime(fld);
            DateTime Birthdate = Convert.ToDateTime(birthdate);

            dc.InsertUser(UserId, name, login, password, avatar, email, Sn_Id, Fld, ms, job, Birthdate, gender, hair,
                          CarId,regnumber, country, brand, model, color);
        }*/
         
             public int SendMessage(Stream JSONdataStream)
      {
        try
        {
            // Read in our Stream into a string...
            StreamReader reader = new StreamReader(JSONdataStream);
            string JSONdata = reader.ReadToEnd();

            // ..then convert the string into a single "wsOrder" record.
            JavaScriptSerializer jss = new JavaScriptSerializer();
            wsMessage message = jss.Deserialize<wsMessage>(JSONdata);
            if (message == null)
            {
                // Error: Couldn't deserialize our JSON string into a "wsOrder" object.
                return -2;
            }

            DriversSN_DBClassesDataContext dc = new DriversSN_DBClassesDataContext();
            Message currentmessage = dc.Message.Where(o => o.MessageID == message.MessageID).FirstOrDefault();
            if (currentmessage == null)
            {
                // Couldn't find an [Order] record with this ID
                return -3;         
            }

            // Update our SQL Server [Order] record, with our new Shipping Details (send from whatever
            // app is calling this web service)
            currentmessage.MessageID = message.MessageID;
            currentmessage.UserrID = message.UserID;
            currentmessage.CarRegNumber= message.CarRegNumber;
            currentmessage.MessageText = message.MsgText;
           
            dc.SubmitChanges();

            return 0;     // Success !
          }
          catch (Exception)
          {
            return -1;
          }
      }



           
        }

        /*   public string GetData(string value)
        {
            return string.Format("You entered: {0}", value);
        }*/

        /* public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }*/
    }
