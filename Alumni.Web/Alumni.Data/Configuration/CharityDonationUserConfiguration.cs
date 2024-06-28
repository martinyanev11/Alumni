using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alumni.Data.Models;

namespace Alumni.Data.Configuration
{
    internal class CharityDonationUserConfiguration : IEntityTypeConfiguration<CharityDonationUser>
    {
        public void Configure(EntityTypeBuilder<CharityDonationUser> builder)
        {
            builder.HasKey(cu => new { cu.CharityDonationId, cu.UserId });
        }
    }
}
