using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WebAutoJ
{
     [DataContract]
     [Serializable]
    public class TryCar
    {
        [DataMember]
        public int TCarID { get; set; }
        [DataMember]
        public string TRegNumber { get; set; }
        [DataMember]
        public string TCountry { get; set; }
        [DataMember]
        public int TOwnerID { get; set; }
        [DataMember]
        public string TBrand { get; set; }
        [DataMember]
        public string TModel { get; set; }
        [DataMember]
        public string TColor { get; set; }
    }
}