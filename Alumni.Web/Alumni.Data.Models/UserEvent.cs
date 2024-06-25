using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumni.Data.Models
{
    public class UserEvent
    {
        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; } = null!;
        [Required]
        public User User { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Event))]
        public int EventId { get; set; }
        [Required]
        public Event Event { get; set; } = null!;
    }
}
