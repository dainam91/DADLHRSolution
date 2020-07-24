using DADLHRSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DADLHRSolution.Data.Configurations
{
    public class WorkTypeConfiguration : IEntityTypeConfiguration<WorkType>
    {
        public void Configure(EntityTypeBuilder<WorkType> builder)
        {
            builder.ToTable("WorkType");

            builder.HasKey(e => e.RecId);

            builder.Property(e => e.RecId).HasColumnName("RecID");

            builder.Property(e => e.Daynight).HasColumnName("DAYNIGHT");

            builder.Property(e => e.Days).HasColumnName("DAYS");

            builder.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Normalsundayholiday).HasColumnName("NORMALSUNDAYHOLIDAY");

            builder.Property(e => e.Rate).HasColumnName("RATE");

            builder.Property(e => e.Type).HasColumnName("TYPE");

            builder.Property(e => e.Vtvabsencecode)
                .HasColumnName("VTVABSENCECODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            builder.Property(e => e.Worktypeid)
                .HasColumnName("WORKTYPEID")
                .HasMaxLength(20)
                .IsUnicode(false);

        }
    }
}
