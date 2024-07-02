using Alumni.Data.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Alumni.Web.ViewModels
{
    public class CharityDonationViewModel
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
