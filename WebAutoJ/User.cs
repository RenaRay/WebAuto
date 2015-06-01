using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;


namespace WebAutoJ
{
    [DataContract]
    public class WebUser
    {
        [DataMember]
        public int WebUserID { get; set; }
        [DataMember]
        public string WUName { get; set; }
        [DataMember]
        public string WULogin { get; set; }
        [DataMember]
        public string WUPassword { get; set; }
        [DataMember]
        public string WUAvatar { get; set; }
        [DataMember]
        public string WUEmail { get; set; }
        [DataMember]
        public string WUsn_ID { get; set; }
        [DataMember]
        public string WURegDate { get; set; }
        [DataMember]
        public DateTime? WUFLD { get; set; }
        [DataMember]
        public string WUMS { get; set; }
        [DataMember]
        public string WUJob { get; set; }
        [DataMember]
        public DateTime? WUBirthdate { get; set; }
        [DataMember]
        public string WUGender { get; set; }
        [DataMember]
        public string WUHairColor { get; set; }
    
    }
}