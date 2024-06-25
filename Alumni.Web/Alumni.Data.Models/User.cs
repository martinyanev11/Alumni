using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Alumni.Data.Models
{
    public class User : IdentityUser
    {
        [Required]
        public DateTime CreatedOn {  get; set; }

        [Required]
        public bool IsDeleted { get; set; }

        [Required]
        public DateTime LastEdited { get; set; }

        public IEnumerable<Post>? Posts { get; set; }
        public IEnumerable<Comment>? Comments { get; set; }
        public IEnumerable<UserEvent>? UserEvents { get; set; }
        public IEnumerable<CharityDonation>? CharityDonationsContributed { get; set; }
    }
}
