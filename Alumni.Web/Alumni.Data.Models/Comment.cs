using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumni.Data.Models
{
    public class Comment
    {
        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public DateTime LastEdited { get; set; }

        [Required]
        public bool IsDeleted { get; set; }


        [Required]
        public string CommentId { get; set; } = null!;

        [Required]
        public string Contents { get; set; } = null!;


        [Required]
        [ForeignKey(nameof(Post))]
        public string PostId { get; set; } = null!;

        [Required]
        public Post Post { get; set; } = null!;

        [ForeignKey(nameof(User))]
        public string? UserId { get; set; }
        public User? User { get; set; }

        
    }
}
