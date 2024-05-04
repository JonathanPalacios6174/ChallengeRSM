using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChallengeRSM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChallengeRSM.Infrastructure.Configuration
{
    public class TopProductConfiguration : IEntityTypeConfiguration<vTopProducts>
    {
        public void Configure(EntityTypeBuilder<vTopProducts> builder)
        {
            builder.HasNoKey().ToView(nameof(vTopProducts), "dbo");

            builder.Property(e => e.ProductID).HasColumnName("ProductID");
            builder.Property(e => e.ProductName).HasColumnType("ProductName");
            builder.Property(e => e.ProductCategory)
           .IsRequired()
           .HasMaxLength(50);
            builder.Property(e => e.TotalQuantity).HasColumnName("TotalQuantity");
            builder.Property(e => e.TotalSales).HasColumnType("TotalSales");
        }
    }
}
