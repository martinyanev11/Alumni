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
                Title = "Donate",
                Content = "for this cause",
                CreatedOn = DateTime.Parse("2024-01-24"),
                LastEdited = DateTime.Parse("2024-01-24"),
                IsDeleted = false,
                CharityDonationId = Guid.Parse("59a312f0-e57a-4cd7-9c7e-66a29918792d"),
                DonationGoal = 6000,
                CurrentlyRaisedDonations = 4396,
                ImageUrl = "asd"
            }
            , new CharityDonation()
            {
                Title = "Donate",
                Content = "for this cause",
                CreatedOn =  DateTime.Parse("2024-01-24"),
                LastEdited = DateTime.Parse("2024-06-28"),
                IsDeleted = true,
                CharityDonationId = Guid.Parse("f376c876-984f-4605-b488-d6bc6872c0bf"),
                DonationGoal = 5000,
                CurrentlyRaisedDonations = 5078,
				ImageUrl = "asd"

			}
            , new CharityDonation()
            {
                Title = "Donate",
                Content = "for this cause",
                CreatedOn = DateTime.Parse("2024-01-24"),
                LastEdited = DateTime.Parse("2024-01-24"),
                IsDeleted = false,
                CharityDonationId = Guid.Parse("18065e6b-eb60-4bbc-a877-829e28fc60d6"),
                DonationGoal = 6000,
                CurrentlyRaisedDonations = 34,
				ImageUrl = "asd"
			}
            , new CharityDonation()
            {
                Title = "Donate",
                Content = "for this cause",
                CreatedOn = DateTime.Parse("2024-01-24"),
                LastEdited = DateTime.Parse("2024-01-24"),
                IsDeleted = false,
                CharityDonationId = Guid.Parse("f0e619aac6fc49cb9e4867533f3904ff"),
                DonationGoal = 6069,
                CurrentlyRaisedDonations = 4786,
				ImageUrl = "asd"
			}
            , new CharityDonation()
            {
                Title = "Donate",
                Content = "for this cause",
                CreatedOn = DateTime.Parse("2024-01-24"),
                LastEdited = DateTime.Parse("2024-01-24"),
                IsDeleted = false,
                CharityDonationId = Guid.Parse("d5e58825c20b4e589c6012bc6253681c"),
                DonationGoal = 10342,
                CurrentlyRaisedDonations = 9485,
				ImageUrl = "asd"
			});
        }
    }
}
