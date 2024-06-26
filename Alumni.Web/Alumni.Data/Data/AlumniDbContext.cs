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

            base.OnModelCreating(builder);
        }
    }
}
