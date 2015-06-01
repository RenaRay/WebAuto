using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WebAutoJ
{
     [DataContract]
    public class WebCar
    {
         [DataMember]
        public int WebCarID { get; set; }
        [DataMember]
        public string WCRegNumber { get; set; }
        [DataMember]
        public string WCCountry { get; set; }
       [DataMember]
        public int WCOwnerID { get; set; }
        [DataMember]
        public string WCBrand { get; set; }
        [DataMember]
        public string WCModel { get; set; }       
        [DataMember]
        public string WCColor { get; set; }
        [DataMember]
        public double? WCPrice { get; set; }
        [DataMember]
        public string WCBody { get; set; }
        [DataMember]
        public int? WCProdYear { get; set; }
        [DataMember]
        public double? WCRun { get; set; }
        [DataMember]
        public string WCTransmission { get; set; }
        [DataMember]
        public string WCEngine { get; set; }
        [DataMember]
        public string WCDrive { get; set; }
        [DataMember]
        public bool? WCConflict { get; set; }
        [DataMember]
        public bool? WCOnSale { get; set; }
    }
}