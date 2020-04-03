using ClassLibrary1.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Infrastructure.Persistence.Configurations
{

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasIndex(a => a.Email).IsUnique();
            
            builder.Property(a => a.Name).HasMaxLength(100).IsRequired();
            builder.Property(a => a.Email).HasMaxLength(160).IsRequired();


            builder.HasMany(a => a.LoginHistories)
                .WithOne(a => a.User)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(new User
            {
                ID = -1,
                Age = 30,
                Name = "Vincent",
                Email = "vincent.dagpiN@gmail.com",
                Gender = Gender.Male
            });
        }
    }
}
