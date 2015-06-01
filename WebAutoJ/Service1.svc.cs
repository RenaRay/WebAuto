using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
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

        /* public List<WebUser> GetAllUsers()
         {
             Entities dc = new Entities();
             List<WebUser> results = new List<WebUser>();

             foreach (CarOwner cust in dc.CarOwner)
             {
                 results.Add(new WebUser()
                     {
                         UserID = cust.UserrID,
                         Name = cust.Name,
                         Login = cust.Login
                     });
             }

             return results;
         }*/

        public List<WebCar> GetCarsForCarOwner(string carOwnerID)
        {
            Entities dc = new Entities();
            // dc.Database.SqlQuery();
            // System.Globalization.CultureInfo ci = System.Globalization.CultureInfo.GetCultureInfo("en-US");
            int OwnerID = Convert.ToInt32(carOwnerID);

            List<WebCar> webCars = new List<WebCar>();

            foreach (Car car in dc.Car)
            {
                if (car.CarOwnerId == OwnerID)
                    webCars.Add(new WebCar()
                        {
                            WebCarID = car.CarID,
                            WCRegNumber = car.RegNumber,
                            WCBrand = car.Brand,
                            //CarOwner = car.CarOwnerId,
                            WCColor = car.Color,
                            WCCountry = car.Country,
                            WCModel = car.Model,
                            WCBody = car.CarBody,
                            WCConflict = car.Conflict,
                            WCDrive = car.Drive,
                            WCEngine = car.Engine,
                            WCOnSale = car.OnSale,
                            WCPrice = car.Price,
                            WCProdYear = car.ProdYear,
                            WCRun = car.Run,
                            WCTransmission = car.Transmission
                        });
            }
            return webCars;
        }

        public List<WebMessage> GetNewMessages(string regnumber)
        {
            Entities dc = new Entities();
            // dc.Database.SqlQuery();

            List<WebMessage> webMessages = new List<WebMessage>();

            foreach (Message message in dc.Message)
            {
                if (message.CarRegNumber == regnumber && message.Viewed == false)
                    webMessages.Add(new WebMessage()
                        {
                           // WMCarRegNumber = message.CarRegNumber,
                            WMText = message.MessageText,
                            WMPhoto = message.MsgPhoto,
                            WMGPS = message.GPSCoordinates,
                            WMDateCreated = message.DateCreated
                        });
            }
            return webMessages;
        }

        public WebUser UserEntry(string login, string pass)
        {
            Entities dc = new Entities();
            // dc.Database.SqlQuery();

            WebUser webUser = new WebUser();

            foreach (CarOwner user in dc.CarOwner)
            {
                //все поля нужны?
                if (user.Login == login && user.Password == pass)
                {
                    webUser.WUName = user.Name;
                    webUser.WUAvatar = user.Avatar;
                    webUser.WUBirthdate = user.BirthDate;
                    webUser.WUEmail = user.Email;
                    webUser.WUFLD = user.FirstLicenseDate;
                    webUser.WUGender = user.Gender;
                    webUser.WUHairColor = user.HairColor;
                    webUser.WUJob = user.Occupation;
                    webUser.WUMS = user.MaritalStatus;
                    webUser.WebUserID = user.CarOwnerID;
                }
            }
            return webUser;
        }

        public void AddCar(Stream jStreamCar)
        {
            //bool ok;
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(WebCar));
            WebCar webCar = (WebCar) jsonSerializer.ReadObject(jStreamCar);
            Entities dc = new Entities();
            try
            {
                dc.AddNewCar(webCar.WebCarID, webCar.WCOwnerID, webCar.WCRegNumber, webCar.WCCountry, webCar.WCBrand,
                        webCar.WCModel, webCar.WCColor);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AddTCar(Stream jStream)
        {
            StreamReader reader = new StreamReader(jStream);
            //string JSONdata = reader.ReadToEnd().Replace("\\", @"").Replace(@"rn", @"").Remove(0, 6);
            string JSONdata = reader.ReadToEnd();
            //JSONdata = JSONdata.Remove(JSONdata.Length - 4, 2);
            JavaScriptSerializer jss = new JavaScriptSerializer();
            TryCar tryCar = jss.Deserialize<TryCar>(JSONdata);

            // DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(TryCar));
           // TryCar tryCar = (TryCar) jsonSerializer.ReadObject(jStream);
            Entities dc = new Entities();
            try
            {
                dc.AddNewCar(tryCar.TCarID,tryCar.TOwnerID,tryCar.TRegNumber,tryCar.TCountry,tryCar.TBrand,tryCar.TModel,tryCar.TColor);
            }
            catch (Exception)
            {
                throw;
            }
        }
       

        /*public List<WebMessage> GetMessagesForPeriod(string userid, string start, string end)
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
                        DateCreated=message.DateCreated
                };
            }

            return results;
        }*/

        public void Register (Stream jStreamUser)
         {
             /*(string userid,string name,string  login,string password,string avatar, string email, string sn_id,
            string fld, string ms,string job,string birthdate,string gender,string hair,
            string carid,string regnumber,string country, string brand,string model,string color)*/
        
            StreamReader reader = new StreamReader(jStreamUser);
            string JSONdata = reader.ReadToEnd();
            JavaScriptSerializer jss = new JavaScriptSerializer();
            RegisterUser user = jss.Deserialize<RegisterUser>(JSONdata);

            // DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(TryCar));
            // TryCar tryCar = (TryCar) jsonSerializer.ReadObject(jStream);
            Entities dc = new Entities();
            try
            {
                dc.InsertUser(user.RegUserID, user.RUName, user.RULogin, user.RUPassword, user.RUAvatar, user.RUEmail,
                              user.RUsn_ID,user.RUFLD, user.RUMS, user.RUJob, user.RUBirthdate, user.RUGender, user.RUHairColor,
                              user.RUCarID, user.RURegNumber, user.RUCountry, user.RUBrand, user.RUModel, user.RUColor);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteUser(string userID)
        {
            try
            {
                int UserID = Convert.ToInt32(userID);
                Entities entities = new Entities();
                CarOwner owner = entities.CarOwner.Where(s => s.CarOwnerID == UserID).FirstOrDefault();
               /* if (owner == null)
                {
                    // We couldn't find record with this ID.
                    return 1;
                }*/
                entities.CarOwner.Remove(owner);
                entities.SaveChanges();
            }
            catch (Exception ex)
            {
                //return 1;    // Failed.
                throw;
            }
        }

        /*  public int SendMessage(Stream JSONdataStream)
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
   }*/
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

