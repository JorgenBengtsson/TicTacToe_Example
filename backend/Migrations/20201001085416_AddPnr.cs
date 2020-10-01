using Microsoft.EntityFrameworkCore.Migrations;

namespace TicTacToe_BackEnd.Migrations
{
    public partial class AddPnr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "pnr",
                table: "Players",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "pnr",
                table: "Players");
        }
    }
}
