﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BonusPlusDBEntities : DbContext
    {
        public BonusPlusDBEntities()
            : base("name=BonusPlusDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Benefits> Benefits { get; set; }
        public virtual DbSet<Employers> Employers { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        public virtual DbSet<SuppliersBenefits> SuppliersBenefits { get; set; }
        public virtual DbSet<Workers> Workers { get; set; }
        public virtual DbSet<WorkersBenefits> WorkersBenefits { get; set; }
    }
}
