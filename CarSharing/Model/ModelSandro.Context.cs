﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarSharing.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CarSharingDBEntitiesNew : DbContext
    {
        public CarSharingDBEntitiesNew()
            : base("name=CarSharingDBEntitiesNew")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Antrieb> Antrieb { get; set; }
        public virtual DbSet<Auto> Auto { get; set; }
        public virtual DbSet<Farbe> Farbe { get; set; }
        public virtual DbSet<Getriebeart> Getriebeart { get; set; }
        public virtual DbSet<KennzeichenNummer> KennzeichenNummer { get; set; }
        public virtual DbSet<Marke> Marke { get; set; }
        public virtual DbSet<modell> modell { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Treibstoff> Treibstoff { get; set; }
        public virtual DbSet<Typ> Typ { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}