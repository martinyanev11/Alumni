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
        public Post()
        {
            PostId = new Guid();
            Title = null!;
            Contents = null!;
            UserId = new Guid();
        }
        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public DateTime LastEdited { get; set; }

        [Required]
        public bool IsDeleted { get; set; }

        [Required]
        public Guid PostId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Contents { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public User? User { get; set; }
        [Required]
        public string? ImageUrl { get; set; } = null;


        /*[ForeignKey(nameof(Admin))]
        public string? AdminId { get; set; }
        public Admin? Admin { get; set; }
*/
        public ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();

    }
}
