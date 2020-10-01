using Microsoft.EntityFrameworkCore.Migrations;

namespace TicTacToe_BackEnd.Migrations
{
    public partial class AddAddress2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "playerid",
                table: "Addresses",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_playerid",
                table: "Addresses",
                column: "playerid");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Players_playerid",
                table: "Addresses",
                column: "playerid",
                principalTable: "Players",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Players_playerid",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_playerid",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "playerid",
                table: "Addresses");
        }
    }
}
