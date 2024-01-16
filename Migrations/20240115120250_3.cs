using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagazinOnline.Migrations
{
    /// <inheritdoc />
    public partial class _3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "ArticolComandat",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ArticolComandat_ClientId",
                table: "ArticolComandat",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArticolComandat_Client_ClientId",
                table: "ArticolComandat",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "ClientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticolComandat_Client_ClientId",
                table: "ArticolComandat");

            migrationBuilder.DropIndex(
                name: "IX_ArticolComandat_ClientId",
                table: "ArticolComandat");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "ArticolComandat");
        }
    }
}
