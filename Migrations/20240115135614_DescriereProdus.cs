using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagazinOnline.Migrations
{
    /// <inheritdoc />
    public partial class DescriereProdus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticolComandat_Client_ClientId",
                table: "ArticolComandat");

            migrationBuilder.DropIndex(
                name: "IX_ArticolComandat_ClientId",
                table: "ArticolComandat");

            migrationBuilder.DropColumn(
                name: "Pret",
                table: "Produs");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "ArticolComandat");

            migrationBuilder.AddColumn<string>(
                name: "Descriere",
                table: "Produs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<decimal>(
                name: "Pret",
                table: "ArticolComandat",
                type: "decimal(6,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descriere",
                table: "Produs");

            migrationBuilder.AddColumn<decimal>(
                name: "Pret",
                table: "Produs",
                type: "decimal(6,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Pret",
                table: "ArticolComandat",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,2)");

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
    }
}
