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
        public Comment()
        {
            CommentId = new Guid();
            Contents = null!;
            PostId = new Guid();
            Post = null!;
            UserId = new Guid();
        }
        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public DateTime LastEdited { get; set; }

        [Required]
        public bool IsDeleted { get; set; }


        [Required]
        public Guid CommentId { get; set; }

        [Required]
        public string Contents { get; set; }


        [Required]
        [ForeignKey(nameof(Post))]
        public Guid PostId { get; set; }

        [Required]
        public Post Post { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public User? User { get; set; }


    }
}
