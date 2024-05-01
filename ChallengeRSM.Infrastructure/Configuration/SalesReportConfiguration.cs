using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChallengeRSM.Infrastructure.Models;
using ChallengeRSM.Infrastructure.Test;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace ChallengeRSM.Infrastructure.Test;

public partial class SalesReportConfiguration : IEntityTypeConfiguration<vSalesReport>
{
 

    public void Configure(EntityTypeBuilder<vSalesReport> builder)
    {
       
            builder.HasNoKey().ToView(nameof(vSalesReport), "dbo");
       
            builder.Property(e => e.BillingAddress)
                .IsRequired()
                .HasMaxLength(60);
            builder.Property(e => e.CustomerID).HasColumnName("CustomerID");
            builder.Property(e => e.OrderDate).HasColumnType("datetime");
            builder.Property(e => e.OrderID).HasColumnName("OrderID");
            builder.Property(e => e.ProductCategory)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(e => e.ProductID).HasColumnName("ProductID");
            builder.Property(e => e.ProductName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(e => e.SalesPersonID).HasColumnName("SalesPersonID");
            builder.Property(e => e.SalesPersonName)
                .IsRequired()
                .HasMaxLength(101);
            builder.Property(e => e.ShippingAddress)
                .IsRequired()
                .HasMaxLength(60);
            builder.Property(e => e.TotalPrice).HasColumnType("money");
            builder.Property(e => e.UnitPrice).HasColumnType("money");
        

        
    }

  
}