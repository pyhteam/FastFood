using FastFood.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace FastFood.Data.Configurations
{
    public class FoodConfiguration : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name).IsRequired().HasMaxLength(250);
            builder.Property(a => a.Slug).IsRequired().HasMaxLength(250);
            builder.Property(a => a.Summary).IsRequired().HasMaxLength(250);
            builder.Property(a => a.Description).IsRequired();
            builder.Property(a => a.Price).IsRequired();
            builder.Property(a => a.CategoryFoodId).IsRequired();
            builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.UpdatedAt).HasDefaultValue(DateTime.Now);
            // foreign key
            builder.HasOne(a => a.CategoryFood).WithMany(a => a.Foods).HasForeignKey(a => a.CategoryFoodId).OnDelete(DeleteBehavior.Cascade);
            
        }
    }
}
