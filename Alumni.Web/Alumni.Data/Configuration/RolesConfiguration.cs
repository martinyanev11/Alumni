﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumni.Data.Configuration
{
    public class RolesConfiguration : IEntityTypeConfiguration<IdentityRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityRole<Guid>> builder)
        {
            builder.HasData(new IdentityRole<Guid>
            {
                Id = Guid.Parse("D23FE586-7D83-4AA3-BAB5-99CF956D0522"),
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = "4FF41592-5852-41D2-AC58-15B64B4BDF34"

            });

           
        }
        



    }
}
