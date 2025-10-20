using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace lab10.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<lab10.Data.Otdelenie> Otdelenie { get; set; } = default!;

        public DbSet<lab10.Data.Palata> Palata { get; set; } = default!;

        public DbSet<lab10.Data.Patient> Patient { get; set; } = default!;
    }


    }
