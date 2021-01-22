using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkAPI.Solution.Migrations
{
    public partial class ChangeParkFeesToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Fees",
                table: "Parks",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Fees",
                table: "Parks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
