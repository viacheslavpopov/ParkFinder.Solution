namespace ParkFinder.Models
{
    public class Location // one loc to many parks
    {
        public int LocationId { get; set; }
        public string City { get; set; } //exception no associated city
        public string State { get; set; } //edge(?) case multiple states to one park
        public string Country { get; set; } //make it international!
        public string Region { get; set; } // alt to no city associations and/or very large spanning parks
        public int ParkId { get; set; }
        public Park Park { get; set; }
    }
}