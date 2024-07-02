using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumni.Data.Models
{
    public class CharityDonation
    {
        public CharityDonation()
        {
            CharityDonationId = new Guid();
            Donators = new HashSet<CharityDonationUser>();
        }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public string? ImageUrl { get; set; } = null;
        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public DateTime LastEdited { get; set; }

        [Required]
        public bool IsDeleted { get; set; }


        [Required]
        public Guid CharityDonationId { get; set; }

        [Required]
        [Column(TypeName = "decimal(12,3)")]
        public decimal DonationGoal { get; set; }

        [Required]
        [Column(TypeName = "decimal(12,3)")]
        public decimal CurrentlyRaisedDonations { get; set; }

        public IEnumerable<CharityDonationUser> Donators { get; set; }

    }
}
