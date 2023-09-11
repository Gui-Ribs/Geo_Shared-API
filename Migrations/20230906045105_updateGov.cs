using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeoShared.Migrations
{
    /// <inheritdoc />
    public partial class updateGov : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Continente_Bioma_BiomaName",
                table: "Continente");

            migrationBuilder.DropForeignKey(
                name: "FK_Governador_Provincia_provinciaName",
                table: "Governador");

            migrationBuilder.RenameColumn(
                name: "provinciaName",
                table: "Governador",
                newName: "Provincia");

            migrationBuilder.RenameIndex(
                name: "IX_Governador_provinciaName",
                table: "Governador",
                newName: "IX_Governador_Provincia");

            migrationBuilder.RenameColumn(
                name: "BiomaName",
                table: "Continente",
                newName: "Bioma");

            migrationBuilder.RenameIndex(
                name: "IX_Continente_BiomaName",
                table: "Continente",
                newName: "IX_Continente_Bioma");

            migrationBuilder.AddForeignKey(
                name: "FK_Continente_Bioma_Bioma",
                table: "Continente",
                column: "Bioma",
                principalTable: "Bioma",
                principalColumn: "name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Governador_Provincia_Provincia",
                table: "Governador",
                column: "Provincia",
                principalTable: "Provincia",
                principalColumn: "code",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Continente_Bioma_Bioma",
                table: "Continente");

            migrationBuilder.DropForeignKey(
                name: "FK_Governador_Provincia_Provincia",
                table: "Governador");

            migrationBuilder.RenameColumn(
                name: "Provincia",
                table: "Governador",
                newName: "provinciaName");

            migrationBuilder.RenameIndex(
                name: "IX_Governador_Provincia",
                table: "Governador",
                newName: "IX_Governador_provinciaName");

            migrationBuilder.RenameColumn(
                name: "Bioma",
                table: "Continente",
                newName: "BiomaName");

            migrationBuilder.RenameIndex(
                name: "IX_Continente_Bioma",
                table: "Continente",
                newName: "IX_Continente_BiomaName");

            migrationBuilder.AddForeignKey(
                name: "FK_Continente_Bioma_BiomaName",
                table: "Continente",
                column: "BiomaName",
                principalTable: "Bioma",
                principalColumn: "name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Governador_Provincia_provinciaName",
                table: "Governador",
                column: "provinciaName",
                principalTable: "Provincia",
                principalColumn: "code",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
