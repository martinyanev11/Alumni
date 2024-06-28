using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumni.Data.Models
{
    public class Event
    {
        public Event()
        {
            EventId = new Guid();
            Title = null!;
            Contents = null!;
        }
        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public DateTime LastEdited { get; set; }

        [Required]
        public bool IsDeleted { get; set; }

        [Required]
        public Guid EventId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Contents { get; set; }

        [Required]
        public DateTime StartDateTime { get; set; }

        [Required]
        public DateTime EndDateTime { get; set; }

        public ICollection<UserEvent> EventUsers { get; set; } = new HashSet<UserEvent>();

    }
}
