﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhuTungXeMay2019.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CsK23T2bEntities : DbContext
    {
        public CsK23T2bEntities()
            : base("name=CsK23T2bEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Dathang> Dathangs { get; set; }
        public virtual DbSet<Donhang> Donhangs { get; set; }
        public virtual DbSet<Khachhang> Khachhangs { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
    }
}
