//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAutoJ
{
    using System;
    using System.Collections.Generic;
    
    public partial class Message
    {
        public int MessageID { get; set; }
        public Nullable<int> UserID { get; set; }
        public string MessageText { get; set; }
        public byte[] MsgPhoto { get; set; }
        public string GPSCoordinates { get; set; }
        public string CarRegNumber { get; set; }
        public Nullable<bool> Viewed { get; set; }
        public Nullable<bool> Score { get; set; }
        public DateTime DateCreated { get; set; }
    
        public virtual CarOwner CarOwner { get; set; }
        public virtual Message_History Message_History { get; set; }
    }
}
