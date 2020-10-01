using Microsoft.EntityFrameworkCore.Migrations;

namespace TicTacToe_BackEnd.Migrations
{
    public partial class AddAddress3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "addressid",
                table: "Players",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Players_addressid",
                table: "Players",
                column: "addressid");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Addresses_addressid",
                table: "Players",
                column: "addressid",
                principalTable: "Addresses",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Addresses_addressid",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_addressid",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "addressid",
                table: "Players");

            migrationBuilder.AddColumn<int>(
                name: "playerid",
                table: "Addresses",
                type: "int",
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
    }
}
