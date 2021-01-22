using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkAPI.Solution.Migrations
{
    public partial class AddParkProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Alerts",
                table: "Parks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BasicInfo",
                table: "Parks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Directions",
                table: "Parks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Fees",
                table: "Parks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "HasHikingTrails",
                table: "Parks",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasVisitorCenter",
                table: "Parks",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "InternetAccess",
                table: "Parks",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsCurrentlyOpen",
                table: "Parks",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ParkAddress",
                table: "Parks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RequiredPasses",
                table: "Parks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeOfPark",
                table: "Parks",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alerts",
                table: "Parks");

            migrationBuilder.DropColumn(
                name: "BasicInfo",
                table: "Parks");

            migrationBuilder.DropColumn(
                name: "Directions",
                table: "Parks");

            migrationBuilder.DropColumn(
                name: "Fees",
                table: "Parks");

            migrationBuilder.DropColumn(
                name: "HasHikingTrails",
                table: "Parks");

            migrationBuilder.DropColumn(
                name: "HasVisitorCenter",
                table: "Parks");

            migrationBuilder.DropColumn(
                name: "InternetAccess",
                table: "Parks");

            migrationBuilder.DropColumn(
                name: "IsCurrentlyOpen",
                table: "Parks");

            migrationBuilder.DropColumn(
                name: "ParkAddress",
                table: "Parks");

            migrationBuilder.DropColumn(
                name: "RequiredPasses",
                table: "Parks");

            migrationBuilder.DropColumn(
                name: "TypeOfPark",
                table: "Parks");
        }
    }
}
