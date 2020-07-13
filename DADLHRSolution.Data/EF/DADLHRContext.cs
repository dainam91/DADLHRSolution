using DADLHRSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DADLHRSolution.Data.EF
{
    public class DADLHRContext : DbContext
    {
        public DADLHRContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<WorkType> WorkTypes { get; set; }
    }
}
