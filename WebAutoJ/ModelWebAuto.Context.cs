﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Car> Car { get; set; }
        public DbSet<Car_History> Car_History { get; set; }
        public DbSet<CarOwner> CarOwner { get; set; }
        public DbSet<CarOwner_History> CarOwner_History { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<Message_History> Message_History { get; set; }
        public DbSet<Userr> Userr { get; set; }
    }
}