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
        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public DateTime LastEdited { get; set; }

        [Required]
        public bool IsDeleted { get; set; }


        [Required]
        public int EventId { get; set; }

        [Required]
        public string Title { get; set; } = null!;

        [Required]
        public string Contents { get; set; } = null!;

        [Required]
        public DateTime StartDateTime { get; set; }

        [Required]
        public DateTime EndDateTime { get; set; }


        [Required]
        [ForeignKey(nameof(Admin))]
        public string AdminId { get; set; } = null!;
        public Admin Admin { get; set; } = null!;

        public List<UserEvent>? EventUsers { get; set; }

    }
}
