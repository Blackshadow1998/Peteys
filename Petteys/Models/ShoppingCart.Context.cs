﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Petteys.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PetteyEntities : DbContext
    {
        public PetteyEntities()
            : base("name=PetteyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Pet> Pet { get; set; }
        public DbSet<Popular> Popular { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Trainer> Trainer { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Customer2> Customer2 { get; set; }
        public DbSet<Order_details> Order_details { get; set; }
        public DbSet<Orders> Orders { get; set; }
    }
}
