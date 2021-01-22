using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkFinder.Solution.Migrations
{
    public partial class ChangeParkNameIntToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ParkName",
                table: "Parks",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ParkName",
                table: "Parks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
