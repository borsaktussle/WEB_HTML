﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace final.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KepoITEntities : DbContext
    {
        public KepoITEntities()
            : base("name=KepoITEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ANSWER> ANSWER { get; set; }
        public DbSet<KATEGORY_REPORT> KATEGORY_REPORT { get; set; }
        public DbSet<KOMENTAR> KOMENTAR { get; set; }
        public DbSet<LEVEL_USER> LEVEL_USER { get; set; }
        public DbSet<QUESTION> QUESTION { get; set; }
        public DbSet<REPORT> REPORT { get; set; }
        public DbSet<STATUS> STATUS { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<TAGS> TAGS { get; set; }
        public DbSet<TAGS_QUESTION> TAGS_QUESTION { get; set; }
        public DbSet<TAGS_SHARING> TAGS_SHARING { get; set; }
        public DbSet<USER> USER { get; set; }
        public DbSet<SHARING> SHARING { get; set; }
    }
}
