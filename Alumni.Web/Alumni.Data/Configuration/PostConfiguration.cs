using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Alumni.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alumni.Data.Configuration
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasData(
             new Post
             {
                 Contents = "On the 23.08.24 the alumni of Softuni Buditel will gather for a tea party in South park",
                 IsDeleted = false,
                 PostId = Guid.Parse("ecfccb98-75a2-49ee-910d-e5a5ec44ae5b"),
                 CreatedOn = DateTime.Parse("2024-06-27"),
                 LastEdited = DateTime.Parse("2024-06-28"),
                 Title = "Alumni gathering",
                 UserId = Guid.Parse("7388ce0f-df30-4686-9e49-46daac4e0292")
             }
             , new Post
             {
                 Contents = "My master is a guy who likes to wear black and fights crime",
                 IsDeleted = false,
                 PostId = Guid.Parse("7463e718-280e-47b6-93b3-f6d629e26a9d"),
                 CreatedOn = DateTime.Parse("2024-06-26"),
                 LastEdited = DateTime.Parse("2024-06-26"),
                 Title = "Just a random post",
                 UserId = Guid.Parse("30913bf8-4000-4809-801e-764de3136c0e")
             }
             , new Post
             {
                 Contents = "I am prince Ferdinand, the first tzar of the new Bulgaria",
                 IsDeleted = true,
                 PostId = Guid.Parse("ee03701f-f3c6-4872-8dc8-800a99947a9d"),
                 CreatedOn = DateTime.Parse("2024-06-28"),
                 LastEdited = DateTime.Parse("2024-06-28"),
                 Title = "Listen to your tzar",
                 UserId = Guid.Parse("8d7ed0e0-1804-4283-aa5b-802033b2c918")
             }
             , new Post
             {
                 Contents = "Hello everyone! I hope this message finds you well. I’m excited to announce the launch of our new alumni mentorship program, designed to connect recent graduates with experienced professionals. It's a great way to share your expertise, give back to our community, and help guide the next generation. Looking forward to seeing many of you get involved!",
                 IsDeleted = false,
                 CreatedOn = DateTime.Parse("2024-06-28"),
                 LastEdited = DateTime.Parse("2024-06-28"),
                 Title = "Test",
                 PostId = Guid.Parse("2fae760d-6a45-45ed-ae78-e4451ebf47f8"),
                 UserId = Guid.Parse("7388ce0f-df30-4686-9e49-46daac4e0292")
             }
             , new Post
             {
                 Contents = "Hello everyone! I hope this message finds you well. I’m excited to announce the launch of our new alumni mentorship program, designed to connect recent graduates with experienced professionals. It's a great way to share your expertise, give back to our community, and help guide the next generation. Looking forward to seeing many of you get involved!",
                 IsDeleted = false,
                 CreatedOn = DateTime.Parse("2024-06-28"),
                 LastEdited = DateTime.Parse("2024-06-28"),
                 Title = "Test",
                 PostId = Guid.Parse("22a984ee-76a2-4c73-b0bf-7ac5e30ccc1b"),
                 UserId = Guid.Parse("7388ce0f-df30-4686-9e49-46daac4e0292")
             }
             , new Post
             {

                 Contents = "Hello everyone! I hope you're doing well. I'm thrilled to announce the launch of our new alumni mentorship program.This initiative aims to connect recent graduates with seasoned professionals.It's a fantastic opportunity to share your knowledge, give back to our community, and guide the next generation. I look forward to seeing many of you participate!",
                 IsDeleted = false,
                 CreatedOn = DateTime.Parse("2024-06-28"),
                 LastEdited = DateTime.Parse("2024-06-28"),
                 Title = "Test",
                 PostId = Guid.Parse("62c9dd2b-1ad2-4089-a157-c358c0422884"),
                 UserId = Guid.Parse("7388ce0f-df30-4686-9e49-46daac4e0292")
             });
        }
    }
}
