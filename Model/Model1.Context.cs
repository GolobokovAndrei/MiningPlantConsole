﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiningPlantConsole.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MiningPlantEntities1 : DbContext
    {
        public MiningPlantEntities1()
            : base("name=MiningPlantEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Destinations> Destinations { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<EquipmentMaterials> EquipmentMaterials { get; set; }
        public virtual DbSet<MilitaryContracts> MilitaryContracts { get; set; }
        public virtual DbSet<Minerals> Minerals { get; set; }
        public virtual DbSet<MineralTracking> MineralTracking { get; set; }
        public virtual DbSet<OperationTypes> OperationTypes { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<OrderStatuses> OrderStatuses { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<SocialPrograms> SocialPrograms { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Taxes> Taxes { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
