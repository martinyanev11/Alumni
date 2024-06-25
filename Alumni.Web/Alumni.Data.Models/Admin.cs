using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumni.Data.Models
{
    public class Admin : IdentityUser
    {
        [Required]
        public DateTime CreatedOn { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
        [Required]
        public DateTime LastEdited { get; set; }

        public IEnumerable<Post>? Posts { get; set; }
        public IEnumerable<Comment>? Comments { get; set; }
        public IEnumerable<Event>? EventsCreated { get; set; }
        public IEnumerable<News>? News { get; set; }
        public IEnumerable<CharityDonation>? CharityDonationsCreated { get; set; }
    }
}
