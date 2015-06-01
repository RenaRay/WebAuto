using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WebAutoJ
{
    [DataContract]
    public class WebMessage
    {
        /*[DataMember]
        public int WebMessageID { get; set; }*/
        /*[DataMember]
        public int WMUserID { get; set; }*/
        [DataMember]
        public string WMText { get; set; }
        [DataMember]
        public byte[] WMPhoto { get; set; }
        [DataMember]
        public string WMGPS { get; set; }
        /*[DataMember]
        public string WMCarRegNumber { get; set; }*/
        /*[DataMember]
        public bool WMViewed { get; set; }
        [DataMember]
        public bool WMScore { get; set; }*/
        [DataMember]
        public DateTime WMDateCreated { get; set; }
    }
}