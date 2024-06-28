using Alumni.Data.Configuration;
using Alumni.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Alumni.Data.Data
{
    public class AlumniDbContext : IdentityDbContext<User,IdentityRole<Guid>,Guid>
    {
        public AlumniDbContext(DbContextOptions<AlumniDbContext> options)
            : base(options)
        {
        }

        public DbSet<Event> Events { get; set; } = null!;
        public DbSet<Post> Posts { get; set; } = null!;
        public DbSet<News> News { get; set; } = null!;
        public DbSet<CharityDonation> CharityDonations { get; set; } = null!;
        public DbSet<UserEvent> UsersEvents { get; set; } = null!;
        public DbSet<Comment> Comments { get; set; } = null!;
        public DbSet<CharityDonationUser> CharityDonationsUsers { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserEventConfiguration());
            builder.ApplyConfiguration(new CharityDonationUserConfiguration());
            builder.ApplyConfiguration(new CommentConfiguration());

            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new NewsConfiguration());
            builder.ApplyConfiguration(new PostConfiguration());
            builder.ApplyConfiguration(new EventConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
