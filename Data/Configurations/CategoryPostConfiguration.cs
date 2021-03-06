using FastFood.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace FastFood.Data.Configurations
{
    public class CategoryPostConfiguration : IEntityTypeConfiguration<CategoryPost>
    {
        public void Configure(EntityTypeBuilder<CategoryPost> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name).IsRequired().HasMaxLength(150).IsUnicode();
            builder.Property(a => a.Slug).IsRequired().HasMaxLength(150);
           
            builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.UpdatedAt).HasDefaultValue(DateTime.Now);
        }
    }
}
