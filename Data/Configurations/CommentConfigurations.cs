using FastFood.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace FastFood.Data.Configurations
{
    public class CommentConfigurations : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Content).IsRequired().IsUnicode();

            builder.Property(a => a.PostId).IsRequired();
            builder.Property(a => a.UserId).IsRequired();
            builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.UpdatedAt).HasDefaultValue(DateTime.Now);

            // foreign keys 
            builder.HasOne(a => a.Parent).WithMany(a => a.Comments).HasForeignKey(a => a.ParentId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(a => a.Post).WithMany(a => a.Comments).HasForeignKey(a => a.PostId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(a => a.User).WithMany(a => a.Comments).HasForeignKey(a => a.UserId).OnDelete(DeleteBehavior.NoAction);
           

        }
    }
}
