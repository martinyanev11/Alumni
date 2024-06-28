using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Alumni.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alumni.Data.Configuration
{
    public class CharityDonationConfiguration : IEntityTypeConfiguration<CharityDonation>
    {
        public void Configure(EntityTypeBuilder<CharityDonation> builder)
        {
            builder.HasData(new CharityDonation()
            {
                CreatedOn = new DateTime(2024, 03, 12, 08, 40, 56),
                LastEdited = new DateTime(2024, 06, 25, 20, 24, 7),
                IsDeleted = false,
                CharityDonationId = Guid.Parse("59a312f0-e57a-4cd7-9c7e-66a29918792d"),
                DonationGoal = 6000,
                CurrentlyRaisedDonations = 4396
            }
            , new CharityDonation()
            {
                CreatedOn = new DateTime(2024, 01, 24, 17, 32, 2),
                LastEdited = DateTime.Parse("2024-06-28"),
                IsDeleted = true,
                CharityDonationId = Guid.Parse("f376c876-984f-4605-b488-d6bc6872c0bf"),
                DonationGoal = 5000,
                CurrentlyRaisedDonations = 5078
            }
            , new CharityDonation()
            {
                CreatedOn = new DateTime(2024, 06, 06, 14, 20, 37),
                LastEdited = new DateTime(2024, 06, 07, 16, 28, 31),
                IsDeleted = false,
                CharityDonationId = Guid.Parse("18065e6b-eb60-4bbc-a877-829e28fc60d6"),
                DonationGoal = 6000,
                CurrentlyRaisedDonations = 34
            }
            , new CharityDonation()
            {
                CreatedOn = new DateTime(2024, 16, 06, 14, 20, 37),
                LastEdited = new DateTime(2024, 26, 07, 16, 28, 31),
                IsDeleted = false,
                CharityDonationId = Guid.Parse("f0e619aac6fc49cb9e4867533f3904ff"),
                DonationGoal = 6069,
                CurrentlyRaisedDonations = 4786
            }
            , new CharityDonation()
            {
                CreatedOn = new DateTime(2024, 06, 06, 14, 20, 37),
                LastEdited = new DateTime(2024, 06, 07, 16, 28, 31),
                IsDeleted = false,
                CharityDonationId = Guid.Parse("d5e58825c20b4e589c6012bc6253681c"),
                DonationGoal = 10342,
                CurrentlyRaisedDonations = 9485
            });
        }
    }
}
