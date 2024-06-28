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
        public CharityDonationUser()
        {
            CharityDonationId = new Guid();
            CharityDonation = null!;
            UserId = new Guid();
            User = null!;

        }
        [Required]
        [ForeignKey(nameof(CharityDonation))]
        public Guid CharityDonationId { get; set; }
        [Required]
        public CharityDonation CharityDonation { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        [Required]
        public User User { get; set; }
    }
}
