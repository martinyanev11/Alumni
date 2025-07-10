using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumni.Services.ServicesForCharityDonations.Models
{
    public class CharityDonationFormModel
    {
        public string Title { get; set; } = null!;

        public string Content { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public decimal DonationGoal { get; set; }
    }
}
