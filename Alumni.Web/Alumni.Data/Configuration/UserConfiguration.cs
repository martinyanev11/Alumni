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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.HasData(new User
            {

                UserName = "Vasko Bilkata",
                CreatedOn = DateTime.Parse("2024-06-20"),
                IsDeleted = false,
                LastEdited = DateTime.Parse("2024-06-20"),
                Id = Guid.Parse("8d7ed0e0-1804-4283-aa5b-802033b2c918")
            }
            , new User
            {
                UserName = "Michael Caine",
                CreatedOn = DateTime.Parse("2024-06-24"),
                IsDeleted = true,
                LastEdited = DateTime.Parse("2024-06-28"),
                Id = Guid.Parse("30913bf8-4000-4809-801e-764de3136c0e")
            }
            , new User
            {
                UserName = "Prince Ferdinand",
                CreatedOn = DateTime.Parse("2024-06-28"),
                IsDeleted = false,
                LastEdited = DateTime.Parse("2024-07-02"),
                Id = Guid.Parse("7388ce0f-df30-4686-9e49-46daac4e0292")
            }
            , new User
            {
                UserName = "Burxh califchar",
                CreatedOn = DateTime.Now,
                IsDeleted = false,
                LastEdited = DateTime.Now.AddDays(7),
                Id = Guid.Parse("b6a98fd4b8db4566ad8cd7c49f3bd2db")
            }
            , new User
            {
                UserName = "gazelle trueman",
                CreatedOn = DateTime.Now.AddDays(13),
                IsDeleted = true,
                LastEdited = DateTime.Now.AddDays(14),
                Id = Guid.Parse("6609e8afabbe4472a1ffab5fdfb92f80")
            }); ;
        }
    }
}
