using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;


namespace WebAutoJ
{
    [DataContract]
    public class wsUser
    {
        [DataMember]
        public int UserID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Login { get; set; }

      /*  [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string Avatar { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string sn_ID { get; set; }

        [DataMember]
        public string RegDate { get; set; }*/
    
    
    
    }
}