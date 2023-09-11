using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeoShared.Migrations
{
    /// <inheritdoc />
    public partial class FKGeneral : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                newName: "provincia");

            migrationBuilder.RenameIndex(
                name: "IX_Governador_Provincia",
                table: "Governador",
                newName: "IX_Governador_provincia");

            migrationBuilder.RenameColumn(
                name: "Bioma",
                table: "Continente",
                newName: "bioma");

            migrationBuilder.RenameIndex(
                name: "IX_Continente_Bioma",
                table: "Continente",
                newName: "IX_Continente_bioma");

            migrationBuilder.AddForeignKey(
                name: "FK_Continente_Bioma_bioma",
                table: "Continente",
                column: "bioma",
                principalTable: "Bioma",
                principalColumn: "name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Governador_Provincia_provincia",
                table: "Governador",
                column: "provincia",
                principalTable: "Provincia",
                principalColumn: "code",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Continente_Bioma_bioma",
                table: "Continente");

            migrationBuilder.DropForeignKey(
                name: "FK_Governador_Provincia_provincia",
                table: "Governador");

            migrationBuilder.RenameColumn(
                name: "provincia",
                table: "Governador",
                newName: "Provincia");

            migrationBuilder.RenameIndex(
                name: "IX_Governador_provincia",
                table: "Governador",
                newName: "IX_Governador_Provincia");

            migrationBuilder.RenameColumn(
                name: "bioma",
                table: "Continente",
                newName: "Bioma");

            migrationBuilder.RenameIndex(
                name: "IX_Continente_bioma",
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
    }
}
