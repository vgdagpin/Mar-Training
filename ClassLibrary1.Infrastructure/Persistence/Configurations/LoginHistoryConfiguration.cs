using ClassLibrary1.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Infrastructure.Persistence.Configurations
{

    public class LoginHistoryConfiguration : IEntityTypeConfiguration<LoginHistory>
    {
        public void Configure(EntityTypeBuilder<LoginHistory> builder)
        {
            builder.HasData(new LoginHistory
            {
                ID = -1,
                UserID = -1,
                LoginDate = DateTime.Now
            });

            builder.HasData(new LoginHistory
            {
                ID = -2,
                UserID = -1,
                LoginDate = DateTime.Now
            });
        }
    }
}
