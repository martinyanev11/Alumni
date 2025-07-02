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
    internal class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<Guid>>
    {
		public void Configure(EntityTypeBuilder<IdentityUserRole<Guid>> builder)
		{
			builder.HasData(
				new IdentityUserRole<Guid>
				{
					UserId = Guid.Parse("8d7ed0e0-1804-4283-aa5b-802033b2c918"), // Existing Admin User ID
					RoleId = Guid.Parse("D23FE586-7D83-4AA3-BAB5-99CF956D0522") // Admin Role ID
				},
				new IdentityUserRole<Guid>
				{
					UserId = Guid.Parse("30913bf8-4000-4809-801e-764de3136c0e"), // New unique GUID for an Alumni User
					RoleId = Guid.Parse("B6154565-C62F-433A-98C6-218FDE24559F") // Alumni Role ID from RolesConfiguration.cs
				},
				new IdentityUserRole<Guid>
				{
					UserId = Guid.Parse("7388ce0f-df30-4686-9e49-46daac4e0292"), // New unique GUID for an Alumni User
					RoleId = Guid.Parse("B6154565-C62F-433A-98C6-218FDE24559F") // Alumni Role ID from RolesConfiguration.cs
				},
				new IdentityUserRole<Guid>
				{
					UserId = Guid.Parse("b6a98fd4b8db4566ad8cd7c49f3bd2db"), // New unique GUID for an Alumni User
					RoleId = Guid.Parse("B6154565-C62F-433A-98C6-218FDE24559F") // Alumni Role ID from RolesConfiguration.cs
				}, new IdentityUserRole<Guid>
				{
					UserId = Guid.Parse("6609e8afabbe4472a1ffab5fdfb92f80"), // New unique GUID for an Alumni User
					RoleId = Guid.Parse("B6154565-C62F-433A-98C6-218FDE24559F") // Alumni Role ID from RolesConfiguration.cs
				}
			);
		}
	}
}
