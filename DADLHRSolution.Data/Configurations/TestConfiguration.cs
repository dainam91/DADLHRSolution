using DADLHRSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DADLHRSolution.Data.Configurations
{
    public class TestConfiguration : IEntityTypeConfiguration<Test>
    {
        public void Configure(EntityTypeBuilder<Test> builder)
        {
            builder.ToTable("Tests");
            builder.HasKey(e => e.TestId);
            builder.Property(e => e.TestName).HasColumnName("TestName");
            builder.Property(e => e.Remark).HasColumnName("Remark");
        }
    }
}
