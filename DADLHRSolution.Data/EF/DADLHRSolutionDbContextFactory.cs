using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DADLHRSolution.Data.EF
{
    public class DADLHRSolutionDbContextFactory : IDesignTimeDbContextFactory<DADLHRContext>
    {
        

        public DADLHRContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DADLHRDB");

            var optionsBuilder = new DbContextOptionsBuilder<DADLHRContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new DADLHRContext(optionsBuilder.Options);

        }
    }
}
