using Microsoft.EntityFrameworkCore.Migrations;

namespace TicTacToe_BackEnd.Migrations
{
    public partial class AddAddress4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "fkAdress",
                table: "Players",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Players_fkAdress",
                table: "Players",
                column: "fkAdress",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Addresses_fkAdress",
                table: "Players",
                column: "fkAdress",
                principalTable: "Addresses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Addresses_fkAdress",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_fkAdress",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "fkAdress",
                table: "Players");

            migrationBuilder.AddColumn<int>(
                name: "addressid",
                table: "Players",
                type: "int",
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
    }
}
