using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumni.Data.Models
{
    public class CharityDonationUser
    {
        [Required]
        [ForeignKey(nameof(CharityDonation))]
        public string CharityDonationId { get; set; } = null!;
        [Required]
        public CharityDonation CharityDonation { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; } = null!;
        [Required]
        public User User { get; set; } = null!;
    }
}
