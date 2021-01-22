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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Location>()

                .HasData(
                    new Location { LocationId = 1, City = "CraterLake", State = "OR", Country = "USA", Region = "Southern Oregon" },
                    new Location { LocationId = 2, City = "Kimberly", State = "OR", Country = "USA", Region = "Eastern Oregon"},
                    new Location { LocationId = 3, City = "Cave Junction", State = "OR", Country = "USA", Region = "Southern Oregon" },
                    new Location { LocationId = 4, City = "Marblemount", State = "WA", Country = "USA", Region = "Northern WA" },
                    new Location { LocationId = 5, City = "Port Angeles", State = "WA", Country = "USA", Region = "Western WA" },
                    new Location { LocationId = 6, City = "Friday Harbor", State = "WA", Country = "USA", Region = "NW WA" }
                );
            builder.Entity<Park>()

                .HasData(
                    new Park { ParkId = 1, ParkName = "Crater Lake", ParkAddress = "TBD", Directions = "TBD", Fees = "TBD", RequiredPasses = "Yes, day passes and annual passes available.", BasicInfo = "Here's some history, geology, local knowledge", Alerts = "Lots of snow! Chains required.", TypeOfPark = "National Park", HasHikingTrails = true, HasVisitorCenter = true, IsCurrentlyOpen = true, InternetAccess = false, LocationId = 1 },
                    new Park { ParkId = 2, ParkName = "John Day Fossil Beds", ParkAddress = "TBD", Directions = "TBD", Fees = "TBD", RequiredPasses = "Yes, day passes and annual passes available.", BasicInfo = "Here's some history, geology, local knowledge", Alerts = "Icy conditions. Drive with caution.", TypeOfPark = "National Monument", HasHikingTrails = true, HasVisitorCenter = true, IsCurrentlyOpen = true, InternetAccess = false, LocationId = 2 },
                    new Park { ParkId = 3, ParkName = "Oregon Caves", ParkAddress = "TBD", Directions = "TBD", Fees = "TBD", RequiredPasses = "Yes, day passes and annual passes available.", BasicInfo = "Here's some history, geology, local knowledge", Alerts = "Landslide on road to OR caves visitor center.", TypeOfPark = "National Monument & Preserve", HasHikingTrails = true, HasVisitorCenter = true, IsCurrentlyOpen = true, InternetAccess = false, LocationId = 3 },
                    new Park { ParkId = 4, ParkName = "North Cascades", ParkAddress = "TBD", Directions = "TBD", Fees = "TBD", RequiredPasses = "Yes, day passes and annual passes available.", BasicInfo = "Here's some history, geology, local knowledge", Alerts = "CLosed for the season.", TypeOfPark = "National Monument & Preserve", HasHikingTrails = true, HasVisitorCenter = true, IsCurrentlyOpen = true, InternetAccess = false, LocationId = 4 },
                    new Park { ParkId = 5, ParkName = "Olympic", ParkAddress = "TBD", Directions = "TBD", Fees = "TBD", RequiredPasses = "Yes, day passes and annual passes available.", BasicInfo = "Here's some history, geology, local knowledge", Alerts = "High tides. See X tide chart for more info.", TypeOfPark = "National Park", HasHikingTrails = true, HasVisitorCenter = false, IsCurrentlyOpen = true, InternetAccess = false, LocationId = 5 },
                    new Park { ParkId = 6, ParkName = "San Juan Island", ParkAddress = "TBD", Directions = "TBD", Fees = "TBD", RequiredPasses = "Yes, day passes and annual passes available.", BasicInfo = "Here's some history, geology, local knowledge", Alerts = "Ferry service delay on all afternoon boats 1.22.21. See WA State Ferries site for more info.", TypeOfPark = "National Monument & Preserve", HasHikingTrails = true, HasVisitorCenter = true, IsCurrentlyOpen = true, InternetAccess = false, LocationId = 6 }
                );
        }
    }
}