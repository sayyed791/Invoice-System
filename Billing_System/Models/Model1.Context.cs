﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Billing_System.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Billing_SystemEntities : DbContext
    {
        public Billing_SystemEntities()
            : base("name=Billing_SystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblcutomer> tblcutomers { get; set; }
        public virtual DbSet<tblproduct> tblproducts { get; set; }
        public virtual DbSet<vender> venders { get; set; }
        public virtual DbSet<tblinvoice> tblinvoices { get; set; }
        public virtual DbSet<tblinvoice_details> tblinvoice_details { get; set; }
        public virtual DbSet<tblinvoice_payment> tblinvoice_payment { get; set; }
        public virtual DbSet<tblinvoice_product> tblinvoice_product { get; set; }
    }
}
