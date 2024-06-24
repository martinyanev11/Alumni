using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Alumni.Data
{
    public class AlumniDbContext : IdentityDbContext
    {
        public AlumniDbContext(DbContextOptions<AlumniDbContext> options)
            : base(options)
        {
        }
    }
}
