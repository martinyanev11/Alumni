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
        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public DateTime LastEdited { get; set; }

        [Required]
        public bool IsDeleted { get; set; }

        [Required]
        public string NewsId { get; set; } = null!;

        [Required]
        public string Title { get; set; } = null!;

        [Required]
        public string Contents { get; set; } = null!;


        public IEnumerable<Comment>? Comments { get; set; }
    }
}
