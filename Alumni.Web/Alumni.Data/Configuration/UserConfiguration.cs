using Alumni.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumni.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
			var hasher = new PasswordHasher<User>();

			var admin = new User
			{
				Id = Guid.Parse("8d7ed0e0-1804-4283-aa5b-802033b2c918"),
				UserName = "VaskoBilkata",
				NormalizedUserName = "VASKOBILKATA",
				Email = "VaskoBilkata@gmail.com",
				NormalizedEmail = "VASKOBILKATA@GMAIL.COM",
				EmailConfirmed = true,
				CreatedOn = DateTime.Parse("2024-06-20"),
				LastEdited = DateTime.Parse("2024-06-20"),
				IsDeleted = false,
				ImageUrl = "asd",
				SecurityStamp = Guid.NewGuid().ToString(),
				ConcurrencyStamp = Guid.NewGuid().ToString()
			};
			admin.PasswordHash = hasher.HashPassword(admin, "Admin123!");

			var user2 = new User
			{
				UserName = "Michael Caine",
				CreatedOn = DateTime.Parse("2024-06-24"),
				IsDeleted = true,
				LastEdited = DateTime.Parse("2024-06-28"),
				Id = Guid.Parse("30913bf8-4000-4809-801e-764de3136c0e"),
				ImageUrl = "asd"
			};
			user2.PasswordHash = hasher.HashPassword(user2, "Password2");

			var user3 = new User
			{
				UserName = "Prince Ferdinand",
				CreatedOn = DateTime.Parse("2024-06-28"),
				IsDeleted = false,
				LastEdited = DateTime.Parse("2024-07-02"),
				Id = Guid.Parse("7388ce0f-df30-4686-9e49-46daac4e0292"),
				ImageUrl = "asd"
			};
			user3.PasswordHash = hasher.HashPassword(user3, "Password3");

			var user4 = new User
			{
				UserName = "Burxh califchar",
				CreatedOn = DateTime.Now,
				IsDeleted = false,
				LastEdited = DateTime.Now.AddDays(7),
				Id = Guid.Parse("b6a98fd4-b8db-4566-ad8c-d7c49f3bd2db"),
				ImageUrl = "asd"
			};
			user4.PasswordHash = hasher.HashPassword(user4, "Password4");

			var user5 = new User
			{
				UserName = "gazelle trueman",
				CreatedOn = DateTime.Now.AddDays(13),
				IsDeleted = true,
				LastEdited = DateTime.Now.AddDays(14),
				Id = Guid.Parse("6609e8af-abbe-4472-a1ff-ab5fdfb92f80"),
				ImageUrl = "asd"
			};
			user5.PasswordHash = hasher.HashPassword(user5, "Password5");

			builder.HasData(admin, user2, user3, user4, user5);

		}
	}
}
