using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkAPI.Solution.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "City", "Country", "Region", "State" },
                values: new object[,]
                {
                    { 1, "CraterLake", "USA", "Southern Oregon", "OR" },
                    { 2, "Kimberly", "USA", "Eastern Oregon", "OR" },
                    { 3, "Cave Junction", "USA", "Southern Oregon", "OR" },
                    { 4, "Marblemount", "USA", "Northern WA", "WA" },
                    { 5, "Port Angeles", "USA", "Western WA", "WA" },
                    { 6, "Friday Harbor", "USA", "NW WA", "WA" }
                });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Alerts", "BasicInfo", "Directions", "Fees", "HasHikingTrails", "HasVisitorCenter", "InternetAccess", "IsCurrentlyOpen", "LocationId", "ParkAddress", "ParkName", "RequiredPasses", "TypeOfPark" },
                values: new object[,]
                {
                    { 1, "Lots of snow! Chains required.", "Here's some history, geology, local knowledge", "TBD", "TBD", true, true, false, true, 1, "TBD", "Crater Lake", "Yes, day passes and annual passes available.", "National Park" },
                    { 2, "Icy conditions. Drive with caution.", "Here's some history, geology, local knowledge", "TBD", "TBD", true, true, false, true, 2, "TBD", "John Day Fossil Beds", "Yes, day passes and annual passes available.", "National Monument" },
                    { 3, "Landslide on road to OR caves visitor center.", "Here's some history, geology, local knowledge", "TBD", "TBD", true, true, false, true, 3, "TBD", "Oregon Caves", "Yes, day passes and annual passes available.", "National Monument & Preserve" },
                    { 4, "CLosed for the season.", "Here's some history, geology, local knowledge", "TBD", "TBD", true, true, false, true, 4, "TBD", "North Cascades", "Yes, day passes and annual passes available.", "National Monument & Preserve" },
                    { 5, "High tides. See X tide chart for more info.", "Here's some history, geology, local knowledge", "TBD", "TBD", true, false, false, true, 5, "TBD", "Olympic", "Yes, day passes and annual passes available.", "National Park" },
                    { 6, "Ferry service delay on all afternoon boats 1.22.21. See WA State Ferries site for more info.", "Here's some history, geology, local knowledge", "TBD", "TBD", true, true, false, true, 6, "TBD", "San Juan Island", "Yes, day passes and annual passes available.", "National Monument & Preserve" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 6);
        }
    }
}
