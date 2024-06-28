using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alumni.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alumni.Data.Configuration
{
    internal class UserEventConfiguration : IEntityTypeConfiguration<UserEvent>
    {
        public void Configure(EntityTypeBuilder<UserEvent> builder)
        {
            builder.HasKey(
                ue => new
                { ue.UserId, ue.EventId }
             );
        }
    }
}
