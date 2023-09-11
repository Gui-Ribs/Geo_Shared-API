using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeoShared.Migrations
{
    /// <inheritdoc />
    public partial class updateProvincia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bioma_Provincia_ProvinciaModelcode",
                table: "Bioma");

            migrationBuilder.DropIndex(
                name: "IX_Bioma_ProvinciaModelcode",
                table: "Bioma");

            migrationBuilder.DropColumn(
                name: "ProvinciaModelcode",
                table: "Bioma");

            migrationBuilder.AddColumn<string>(
                name: "Bioma",
                table: "Provincia",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Biomasname",
                table: "Provincia",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Provincia_Biomasname",
                table: "Provincia",
                column: "Biomasname");

            migrationBuilder.AddForeignKey(
                name: "FK_Provincia_Bioma_Biomasname",
                table: "Provincia",
                column: "Biomasname",
                principalTable: "Bioma",
                principalColumn: "name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Provincia_Bioma_Biomasname",
                table: "Provincia");

            migrationBuilder.DropIndex(
                name: "IX_Provincia_Biomasname",
                table: "Provincia");

            migrationBuilder.DropColumn(
                name: "Bioma",
                table: "Provincia");

            migrationBuilder.DropColumn(
                name: "Biomasname",
                table: "Provincia");

            migrationBuilder.AddColumn<string>(
                name: "ProvinciaModelcode",
                table: "Bioma",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Bioma_ProvinciaModelcode",
                table: "Bioma",
                column: "ProvinciaModelcode");

            migrationBuilder.AddForeignKey(
                name: "FK_Bioma_Provincia_ProvinciaModelcode",
                table: "Bioma",
                column: "ProvinciaModelcode",
                principalTable: "Provincia",
                principalColumn: "code");
        }
    }
}
