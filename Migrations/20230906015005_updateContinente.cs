using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeoShared.Migrations
{
    /// <inheritdoc />
    public partial class updateContinente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Continente_Bioma_BiomaModelname",
                table: "Continente");

            migrationBuilder.DropIndex(
                name: "IX_Continente_BiomaModelname",
                table: "Continente");

            migrationBuilder.DropColumn(
                name: "BiomaModelname",
                table: "Continente");

            migrationBuilder.AddColumn<string>(
                name: "BiomaName",
                table: "Continente",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Continente_BiomaName",
                table: "Continente",
                column: "BiomaName");

            migrationBuilder.AddForeignKey(
                name: "FK_Continente_Bioma_BiomaName",
                table: "Continente",
                column: "BiomaName",
                principalTable: "Bioma",
                principalColumn: "name",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Continente_Bioma_BiomaName",
                table: "Continente");

            migrationBuilder.DropIndex(
                name: "IX_Continente_BiomaName",
                table: "Continente");

            migrationBuilder.DropColumn(
                name: "BiomaName",
                table: "Continente");

            migrationBuilder.AddColumn<string>(
                name: "BiomaModelname",
                table: "Continente",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Continente_BiomaModelname",
                table: "Continente",
                column: "BiomaModelname");

            migrationBuilder.AddForeignKey(
                name: "FK_Continente_Bioma_BiomaModelname",
                table: "Continente",
                column: "BiomaModelname",
                principalTable: "Bioma",
                principalColumn: "name");
        }
    }
}
