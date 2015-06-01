using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WebAutoJ
{
    [DataContract]
    [Serializable]
    public class RegisterUser
    {
        [DataMember]
        public int RegUserID { get; set; }
        [DataMember]
        public string RUName { get; set; }
        [DataMember]
        public string RULogin { get; set; }
        [DataMember]
        public string RUPassword { get; set; }
        [DataMember]
        public string RUAvatar { get; set; }
        [DataMember]
        public string RUEmail { get; set; }
        [DataMember]
        public string RUsn_ID { get; set; }
        [DataMember]
        public string RURegDate { get; set; }
        [DataMember]
        public DateTime? RUFLD { get; set; }
        [DataMember]
        public string RUMS { get; set; }
        [DataMember]
        public string RUJob { get; set; }
        [DataMember]
        public DateTime? RUBirthdate { get; set; }
        [DataMember]
        public string RUGender { get; set; }
        [DataMember]
        public string RUHairColor { get; set; }

        [DataMember]
        public int RUCarID { get; set; }
        [DataMember]
        public string RURegNumber { get; set; }
        [DataMember]
        public string RUCountry { get; set; }
        [DataMember]
        public int RUOwnerID { get; set; }
        [DataMember]
        public string RUBrand { get; set; }
        [DataMember]
        public string RUModel { get; set; }
        [DataMember]
        public string RUColor { get; set; }
    }
}