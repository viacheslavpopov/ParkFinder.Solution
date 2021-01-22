using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkAPI.Solution.Migrations
{
    public partial class FixOneToManyAddParkList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Parks_ParkId",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_ParkId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "ParkId",
                table: "Locations");

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Parks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Parks_LocationId",
                table: "Parks",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Parks_Locations_LocationId",
                table: "Parks",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parks_Locations_LocationId",
                table: "Parks");

            migrationBuilder.DropIndex(
                name: "IX_Parks_LocationId",
                table: "Parks");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Parks");

            migrationBuilder.AddColumn<int>(
                name: "ParkId",
                table: "Locations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_ParkId",
                table: "Locations",
                column: "ParkId");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Parks_ParkId",
                table: "Locations",
                column: "ParkId",
                principalTable: "Parks",
                principalColumn: "ParkId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
