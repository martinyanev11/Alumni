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
    public class NewsConfiguration : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.HasData(new News
            {
                NewsId = Guid.Parse("85183070-d0af-41a1-9b3b-95d0073995eb"),
                CreatedOn = DateTime.Parse("2024-06-28"),
                LastEdited = DateTime.Parse("2024-06-28"),
                IsDeleted = false,
                Title = "News",
                Contents = "Test seed",
				ImageUrl = "/images/event3.jpg"
            }
            , new News
            {
                NewsId = Guid.Parse("fb8f1f7a88534bed8008a17ae2a3be3f"),
                CreatedOn = DateTime.Now.AddDays(-31),
                LastEdited = DateTime.Now.AddDays(75),
                IsDeleted = true,
                Title = "file",
                Contents = "funny haha get shmucked",
				ImageUrl = "/images/event3.jpg"
            }
            , new News
            {
                NewsId = Guid.Parse("31dedd8d0dc7455a955a14d7d5e9320f"),
                CreatedOn = DateTime.Now,
                LastEdited = DateTime.Now,
                IsDeleted = false,
                Title = "News",
                Contents = "f k y u d b j g d",
				ImageUrl = "/images/event3.jpg"
            });
        }
    }
}
