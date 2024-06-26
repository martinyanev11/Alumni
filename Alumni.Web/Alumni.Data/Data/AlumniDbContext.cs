using Alumni.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Alumni.Data.Data
{
    public class AlumniDbContext : IdentityDbContext<User>
    {
        public AlumniDbContext(DbContextOptions<AlumniDbContext> options)
            : base(options)
        {
        }

        public override DbSet<User> Users { get; set; } = null!;
        public DbSet<Event> Events { get; set; } = null!;
        public DbSet<Post> Posts { get; set; } = null!;
        public DbSet<News> News { get; set; } = null!;
        public DbSet<CharityDonation> CharityDonations { get; set; } = null!;
        public DbSet<UserEvent> UsersEvents { get; set; } = null!;
        public DbSet<Comment> Comments { get; set; } = null!;
        public DbSet<CharityDonationUser> CharityDonationsUsers {  get; set; } = null!; 

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserEvent>()
                .HasKey(ue => new { ue.UserId, ue.EventId });

            builder.Entity<CharityDonationUser>()
                .HasKey(cu => new { cu.CharityDonationId, cu.UserId });

            builder.Entity<User>().HasData(new User
            {
                UserName = "Vasko Bilkata",
                CreatedOn = DateTime.Now.AddDays(-8),
                IsDeleted = false,
                LastEdited = DateTime.Now.AddDays(-8),
                Id = "1"  
            });

            builder.Entity<User>().HasData(new User
            {
                UserName = "Michael Caine",
                CreatedOn = DateTime.Now.AddDays(-4),
                IsDeleted = true,
                LastEdited = DateTime.Now,
                Id = "123"  
            });

            builder.Entity<User>().HasData(new User
            {
                UserName = "Prince Ferdinand",
                CreatedOn = DateTime.Now,
                IsDeleted = false,
                LastEdited = DateTime.Now.AddDays(4),
                Id = "102"  
            });


            builder.Entity<Post>().HasData(new Post
            {
                Contents = "On the 23.08.24 the alumni of Softuni Buditel will gather for a tea party in South park",
                IsDeleted = false,
                PostId = Guid.NewGuid().ToString(),
                CreatedOn = DateTime.Now.AddDays(-1),
                LastEdited = DateTime.Now,
                Title = "Alumni gathering",
                UserId = "1"  
            });

            builder.Entity<Post>().HasData(new Post
            {
                Contents = "My master is a guy who likes to wear black and fights crime",
                IsDeleted = false,
                PostId = Guid.NewGuid().ToString(),
                CreatedOn = DateTime.Now.AddDays(-2),
                LastEdited = DateTime.Now.AddDays(-2),
                Title = "Just a random post",
                UserId = "123"  
            });

            builder.Entity<Post>().HasData(new Post
            {
                Contents = "I am prince Ferdinand, the first tzar of the new Bulgaria",
                IsDeleted = true,
                PostId = Guid.NewGuid().ToString(),
                CreatedOn = DateTime.Now,
                LastEdited = DateTime.Now,
                Title = "Listen to your tzar",
                UserId = "102"  
            });

            builder.Entity<Post>().HasData(new Post
            {
                Contents = "Hello everyone! I hope this message finds you well. I’m excited to announce the launch of our new alumni mentorship program, designed to connect recent graduates with experienced professionals. It's a great way to share your expertise, give back to our community, and help guide the next generation. Looking forward to seeing many of you get involved!",
                IsDeleted = false,
                CreatedOn = DateTime.Now,
                LastEdited = DateTime.Now,
                Title = "Test",
                PostId = Guid.NewGuid().ToString(),
                UserId = "1"  
            });

            builder.Entity<Post>().HasData(new Post
            {
                Contents = "Hello everyone! I hope this message finds you well. I’m excited to announce the launch of our new alumni mentorship program, designed to connect recent graduates with experienced professionals. It's a great way to share your expertise, give back to our community, and help guide the next generation. Looking forward to seeing many of you get involved!",
                IsDeleted = false,
                CreatedOn = DateTime.Now,
                LastEdited = DateTime.Now,
                Title = "Test",
                PostId = Guid.NewGuid().ToString(),
                UserId = "1"  
            });

            builder.Entity<Post>().HasData(new Post
            {
                Contents = "Hello everyone! I hope you're doing well. I'm thrilled to announce the launch of our new alumni mentorship program.This initiative aims to connect recent graduates with seasoned professionals.It's a fantastic opportunity to share your knowledge, give back to our community, and guide the next generation. I look forward to seeing many of you participate!",
                IsDeleted = false,
                CreatedOn = DateTime.Now,
                LastEdited = DateTime.Now,
                Title = "Test",
                PostId = Guid.NewGuid().ToString(),
                UserId = "1"  
            });

            builder.Entity<CharityDonation>().HasData(new CharityDonation()
            {
                CreatedOn = new DateTime(2024, 03, 12, 08, 40, 56),
                LastEdited = new DateTime(2024, 06, 25, 20, 24, 7),
                IsDeleted = false,
                CharityDonationId = Guid.NewGuid().ToString(),
                DonationGoal = 6000,
                CurrentlyRaisedDonations = 4396
            });

            builder.Entity<CharityDonation>().HasData(new CharityDonation()
            {
                CreatedOn = new DateTime(2024, 01, 24, 17, 32, 2),
                LastEdited = DateTime.Now,
                IsDeleted = true,
                CharityDonationId = Guid.NewGuid().ToString(),
                DonationGoal = 5000,
                CurrentlyRaisedDonations = 5078
            });

            builder.Entity<CharityDonation>().HasData(new CharityDonation()
            {
                CreatedOn = new DateTime(2024, 06, 06, 14, 20, 37),
                LastEdited = new DateTime(2024, 06, 07, 16, 28, 31),
                IsDeleted = false,
                CharityDonationId = Guid.NewGuid().ToString(),
                DonationGoal = 6000,
                CurrentlyRaisedDonations = 34
            });


            builder.Entity<News>().HasData(new News
            {
                NewsId = Guid.NewGuid().ToString(),
                CreatedOn = DateTime.Now,
                LastEdited = DateTime.Now,
                IsDeleted = false,
                Title = "News",
                Contents = "Test seed"
            });

            builder.Entity<Event>().HasData(new Event
            {
                EventId = Guid.NewGuid().ToString(),
                IsDeleted = false,
                CreatedOn = DateTime.Now,
                LastEdited = DateTime.Now,
                Title = "Meeting - 2016 class",
                Contents = "The class of 2016 is going to have a meeting at the local park. There`s going to be food, but you can bring some.",
                StartDateTime = new DateTime(2024, 05, 02, 17, 30, 00),
                EndDateTime = new DateTime(2024, 05, 02, 20, 00, 00),
            }, new Event
            {
                EventId = Guid.NewGuid().ToString(),
                IsDeleted = false,
                CreatedOn = DateTime.Now,
                LastEdited = DateTime.Now,
                Title = "Meeting - 2011 class",
                Contents = "The class of 2011 is going to have a meeting at the local beach.",
                StartDateTime = new DateTime(2024, 07, 05, 17, 30, 00),
                EndDateTime = new DateTime(2024, 07, 05, 20, 00, 00),
            }, new Event
            {
                EventId = Guid.NewGuid().ToString(),
                IsDeleted = false,
                CreatedOn = DateTime.Now,
                LastEdited = DateTime.Now,
                Title = "Meeting - 2009 class",
                Contents = "The class of 2009 is going to have a meeting at the local pub.",
                StartDateTime = new DateTime(2024, 05, 08, 17, 30, 00),
                EndDateTime = new DateTime(2024, 05, 08, 20, 00, 00),
            });


            base.OnModelCreating(builder);
        }
    }
}
