using Alumni.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Alumni.Data.Configuration
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasData(new Event
            {
                EventId = Guid.Parse("87c281f4-5052-47a5-a6f4-75c9741663ef"),
                IsDeleted = false,
                CreatedOn = DateTime.Parse("2024-06-28"),
                LastEdited = DateTime.Parse("2024-06-28"),
                Title = "Meeting - 2016 class",
                Contents = "The class of 2016 is going to have a meeting at the local park. There`s going to be food, but you can bring some.",
                StartDateTime = new DateTime(2024, 05, 02, 17, 30, 00),
                EndDateTime = new DateTime(2024, 05, 02, 20, 00, 00),
				ImageUrl = "/images/event1.jpg"
			}, new Event
            {
                EventId = Guid.Parse("541e7f5d-4016-474e-acd2-2f30ecd9a446"),
                IsDeleted = false,
                CreatedOn = DateTime.Parse("2024-06-28"),
                LastEdited = DateTime.Parse("2024-06-28"),
                Title = "Meeting - 2011 class",
                Contents = "The class of 2011 is going to have a meeting at the local beach.",
                StartDateTime = new DateTime(2024, 07, 05, 17, 30, 00),
                EndDateTime = new DateTime(2024, 07, 05, 20, 00, 00),
				ImageUrl = "/images/event2.jpg"
            }, new Event
            {
                EventId = Guid.Parse("9a1172e2-e2e5-44fd-92e6-285c1154e8dc"),
                IsDeleted = false,
                CreatedOn = DateTime.Parse("2024-06-28"),
                LastEdited = DateTime.Parse("2024-06-28"),
                Title = "Meeting - 2009 class",
                Contents = "The class of 2009 is going to have a meeting at the local pub.",
                StartDateTime = new DateTime(2024, 05, 08, 17, 30, 00),
                EndDateTime = new DateTime(2024, 05, 08, 20, 00, 00),
				ImageUrl = "/images/event3.jpg"
            }
            , new Event
            {
                EventId = Guid.Parse("832388e9e1d948789299273129c9f247"),
                IsDeleted = true,
                CreatedOn = DateTime.Now,
                LastEdited = DateTime.Now,
                Title = "Meeting - 2003 class",
                Contents = "The class of 2003 is going to have a meeting at the local pub.",
                StartDateTime = new DateTime(2024, 05, 08, 17, 30, 00),
                EndDateTime = new DateTime(2024, 05, 08, 20, 00, 00),
				ImageUrl = "/images/event3.jpg"
            }
            , new Event
            {
                EventId = Guid.Parse("74a8ad71942541158b4455cc94b13a89"),
                IsDeleted = false,
                CreatedOn = DateTime.Now,
                LastEdited = DateTime.Now,
                Title = "Meeting - 2009 class",
                Contents = "The class of 2009 is going to have a meeting at the local pub.",
                StartDateTime = new DateTime(2010, 05, 08, 17, 30, 00),
                EndDateTime = new DateTime(2024, 05, 08, 20, 00, 00),
				ImageUrl = "/images/event1.jpg"
			}
            , new Event
            {
                EventId = Guid.Parse("8f0a57e7afe346488efa9a977602bee0"),
                IsDeleted = false,
                CreatedOn = new DateTime(2025, 05, 08, 17, 30, 00),
                LastEdited = DateTime.Now,
                Title = "Meeting - 2009 class",
                Contents = "The class of 2009 is going to have a meeting at the local pub.",
                StartDateTime = new DateTime(2024, 05, 08, 17, 30, 00),
                EndDateTime = new DateTime(2024, 05, 08, 20, 00, 00),
				ImageUrl = "/images/event1.jpg"
			}
            , new Event
            {
                EventId = Guid.Parse("257cb7addf194caca009f68eeb305afa"),
                IsDeleted = false,
                CreatedOn = new DateTime(2023, 05, 08, 17, 30, 00),
                LastEdited = new DateTime(2022, 05, 08, 17, 30, 00),
                Title = "Meeting - 2009 class",
                Contents = "The class of 2009 is going to have a meeting at the local pub.",
                StartDateTime = new DateTime(2024, 05, 08, 17, 30, 00),
                EndDateTime = new DateTime(2024, 05, 08, 20, 00, 00),
				ImageUrl = "/images/event1.jpg"
			}
            );


        }
    }
}
