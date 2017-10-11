﻿using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using POEItemFilter.EntityConfiguration;
using POEItemFilter.Library.EntityConfiguration;
using POEItemFilter.Models.ItemsDB;

namespace POEItemFilter.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<ItemDB> ItemsDB { get; set; }
        public DbSet<ItemBaseType> BaseTypes { get; set; }
        public DbSet<ItemType> Types { get; set; }

        public ApplicationDbContext()
            : base("POEItemFilterContext", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new ItemDBConfiguration());
            modelBuilder.Configurations.Add(new ItemBaseTypeConfiguration());
            modelBuilder.Configurations.Add(new ItemTypeConfiguration());
        }
    }
}