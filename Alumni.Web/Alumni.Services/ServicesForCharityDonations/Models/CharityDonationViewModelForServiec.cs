using Alumni.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumni.Services.ServicesForCharityDonations.Models
{
    public class CharityDonationViewModelForServiec
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedOn { get; set; }

        public DateTime LastEdited { get; set; }

        public Guid CharityDonationId { get; set; }

        public decimal DonationGoal { get; set; }

        public decimal CurrentlyRaisedDonations { get; set; }
        public string ImageUrl { get; set; }
        public IEnumerable<User>? Donators { get; set; }
    }
}
