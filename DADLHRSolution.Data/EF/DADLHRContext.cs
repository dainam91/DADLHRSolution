using DADLHRSolution.Data.Configurations;
using DADLHRSolution.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DADLHRSolution.Data.EF
{
    public class DADLHRContext : IdentityDbContext
    {
        public DADLHRContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new WorkTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TestConfiguration());
            //base.OnModelCreating(modelBuilder);
        }

        public DbSet<WorkType> WorkTypes { get; set; }
    }
}
