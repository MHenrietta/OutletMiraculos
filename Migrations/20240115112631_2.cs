using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagazinOnline.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorie_Produs_ProdusId",
                table: "Categorie");

            migrationBuilder.DropIndex(
                name: "IX_Categorie_ProdusId",
                table: "Categorie");

            migrationBuilder.DropColumn(
                name: "ProdusId",
                table: "Categorie");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProdusId",
                table: "Categorie",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categorie_ProdusId",
                table: "Categorie",
                column: "ProdusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categorie_Produs_ProdusId",
                table: "Categorie",
                column: "ProdusId",
                principalTable: "Produs",
                principalColumn: "ProdusId");
        }
    }
}
