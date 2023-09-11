using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeoShared.Migrations
{
    /// <inheritdoc />
    public partial class FKBioma : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Provincia_Bioma_Bioma",
                table: "Provincia");

            migrationBuilder.RenameColumn(
                name: "Bioma",
                table: "Provincia",
                newName: "bioma");

            migrationBuilder.RenameIndex(
                name: "IX_Provincia_Bioma",
                table: "Provincia",
                newName: "IX_Provincia_bioma");

            migrationBuilder.AddForeignKey(
                name: "FK_Provincia_Bioma_bioma",
                table: "Provincia",
                column: "bioma",
                principalTable: "Bioma",
                principalColumn: "name",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Provincia_Bioma_bioma",
                table: "Provincia");

            migrationBuilder.RenameColumn(
                name: "bioma",
                table: "Provincia",
                newName: "Bioma");

            migrationBuilder.RenameIndex(
                name: "IX_Provincia_bioma",
                table: "Provincia",
                newName: "IX_Provincia_Bioma");

            migrationBuilder.AddForeignKey(
                name: "FK_Provincia_Bioma_Bioma",
                table: "Provincia",
                column: "Bioma",
                principalTable: "Bioma",
                principalColumn: "name",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
