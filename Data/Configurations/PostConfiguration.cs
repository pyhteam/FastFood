using FastFood.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace FastFood.Data.Configurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Title).IsRequired().HasMaxLength(250).IsUnicode();
            builder.Property(a => a.Slug).IsRequired().HasMaxLength(250);
            builder.Property(a => a.Summary).IsRequired().HasMaxLength(250);
            builder.Property(a => a.Content).IsRequired();
            builder.Property(a => a.Image).IsRequired();
            builder.Property(a => a.UserId).IsRequired();
            builder.Property(a => a.CategoryPostId).IsRequired();
            builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.UpdatedAt).HasDefaultValue(DateTime.Now);
            // foreign key
            builder.HasOne(a => a.User).WithMany(a => a.Posts).HasForeignKey(a => a.UserId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(a => a.CategoryPost).WithMany(a => a.Posts).HasForeignKey(a => a.CategoryPostId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
