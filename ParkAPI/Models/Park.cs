namespace ParkFinder.Models
{
    public class Park // many potential parks to one loc
    {
        public int ParkId { get; set; }
        public int ParkName { get; set; }
        public string ParkAddress { get; set; }
        public string Directions { get; set; }
        public int Fees { get; set; }
        public string RequiredPasses { get; set; }
        public string BasicInfo { get; set; }
        public string Alerts { get; set; }
        public string TypeOfPark { get; set; } //(Nat'l Historic Trail, National Park, Nat'l Historic Site, etc.)
        public bool HasHikingTrails { get; set; } = true;
        public bool HasVisitorCenter { get; set; } = false;
        public bool IsCurrentlyOpen { get; set; } = true; //helpful for covid closures, stretch goal built in park hours, weather advisories, road closures, etc.
        public bool InternetAccess { get; set; } = false; //stretch to string with internet & cell access info

    }
}