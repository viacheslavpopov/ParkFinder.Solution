using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkFinder.Solution.Migrations
{
    public partial class UpdateSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6,
                column: "RequiredPasses",
                value: "None required.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6,
                column: "RequiredPasses",
                value: "Yes, day passes and annual passes available.");
        }
    }
}
