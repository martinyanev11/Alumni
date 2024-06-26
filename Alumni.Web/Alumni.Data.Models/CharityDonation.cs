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
        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public DateTime LastEdited { get; set; }

        [Required]
        public bool IsDeleted { get; set; }


        [Required]
        public string CharityDonationId { get; set; } = null!;

        [Required]
        [Column(TypeName = "decimal(12,3)")]
        public decimal DonationGoal { get; set; }

        [Required]
        [Column(TypeName = "decimal(12,3)")]
        public decimal CurrentlyRaisedDonations { get; set; }


        public IEnumerable<CharityDonationUser>? Donators { get; set; }

    }
}
