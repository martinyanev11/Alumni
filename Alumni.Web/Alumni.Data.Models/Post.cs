using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumni.Data.Models
{
    public class Post
    {
        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public DateTime LastEdited { get; set; }

        [Required]
        public bool IsDeleted { get; set; }

        [Required]
        public int PostId { get; set; }

        [Required]
        public string Title { get; set; } = null!;

        [Required]
        public string Contents { get; set; } = null!;

        [ForeignKey(nameof(User))]
        public string? UserId { get; set; }
        public User? User { get; set; }

        /*[ForeignKey(nameof(Admin))]
        public string? AdminId { get; set; }
        public Admin? Admin { get; set; }
*/
        public IEnumerable<Comment>? Comments { get; set; }

    }
}
