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
    
    public partial class CarOwner_History
    {
        public int CarOwnerID { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> FirstLicenseDate { get; set; }
        public string MaritalStatus { get; set; }
        public string Occupation { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string Gender { get; set; }
        public string HairColor { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<bool> FlagEffective { get; set; }
    
        public virtual CarOwner CarOwner { get; set; }
    }
}
