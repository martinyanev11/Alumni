using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumni.Data.Models
{
    public class News
    {
        public News()
        {
            NewsId = new Guid();
            Title = null!;
            Contents = null!;
        }
        [Required]
        public string? ImageUrl { get; set; } = null;
        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public DateTime LastEdited { get; set; }

        [Required]
        public bool IsDeleted { get; set; }

        [Required]
        public Guid NewsId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Contents { get; set; }


        public ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();
    }
}
