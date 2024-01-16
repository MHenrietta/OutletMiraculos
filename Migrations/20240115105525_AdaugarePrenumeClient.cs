using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagazinOnline.Migrations
{
    /// <inheritdoc />
    public partial class AdaugarePrenumeClient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Prenume",
                table: "Client",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Prenume",
                table: "Client");
        }
    }
}
