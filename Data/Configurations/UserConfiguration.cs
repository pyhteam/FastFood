using FastFood.Models;
using FastFood.Uliti;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace FastFood.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.FirstName).IsRequired().HasMaxLength(100).IsUnicode();
            builder.Property(a => a.LastName).IsRequired().HasMaxLength(100).IsUnicode();
            builder.Property(a => a.Email).IsRequired().HasMaxLength(250);
            builder.Property(a => a.Password).IsRequired();
            builder.Property(a => a.Address).IsRequired().HasMaxLength(250).IsUnicode();
            builder.Property(a => a.Phone).IsRequired().HasMaxLength(20);

            builder.Property(a=>a.Status).HasDefaultValue(EUserStatus.Pending);
            builder.Property(a=>a.Role).HasDefaultValue(ERoles.Member);

            builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.UpdatedAt).HasDefaultValue(DateTime.Now);
        }
    }
}
