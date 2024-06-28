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
        public UserEvent()
        {
            UserId = new Guid();
            User = null!;
            EventId = new Guid();
            Event = null!;
        }
        [Required]
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        [Required]
        public User User { get; set; }

        [Required]
        [ForeignKey(nameof(Event))]
        public Guid EventId { get; set; }
        [Required]
        public Event Event { get; set; }
    }
}
