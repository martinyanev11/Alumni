using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Alumni.Data.Models
{
    public class User : IdentityUser<Guid>
    {
        [Required]
        public string? ImageUrl { get; set; } = null;
        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public bool IsDeleted { get; set; }

        [Required]
        public DateTime LastEdited { get; set; }

        public ICollection<Post> Posts { get; set; } = new HashSet<Post>();
        public ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();
        public ICollection<UserEvent> UserEvents { get; set; } = new HashSet<UserEvent>();
        public ICollection<CharityDonationUser> CharityDonationsContributed { get; set; } = new HashSet<CharityDonationUser>();
    }
}
