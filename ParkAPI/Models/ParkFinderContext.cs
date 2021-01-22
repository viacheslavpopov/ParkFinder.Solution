using Microsoft.EntityFrameworkCore;

namespace ParkFinder.Models
{
    public class ParkFinderContext :DbContext
    {
        public ParkFinderContext(DbContextOptions<ParkFinderContext> options)
            :base(options)
            {
            }

            public DbSet<Park> Parks { get; set;}
            public DbSet<Location> Locations { get; set; }
    }
}