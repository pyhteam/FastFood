using FastFood.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace FastFood.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(a => a.Id);
          
            builder.Property(a => a.OrderType).IsRequired();
            builder.Property(a => a.Status).IsRequired();
            builder.Property(a => a.Amount).IsRequired();
            builder.Property(a => a.TotalPrice).IsRequired();
            builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.UpdatedAt).HasDefaultValue(DateTime.Now);

            // foregin key
            builder.HasOne(a => a.User).WithMany(a => a.Orders).HasForeignKey(a => a.UserId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(a=>a.Foods).WithOne(a=>a.Order).HasForeignKey(a => a.OrderId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
