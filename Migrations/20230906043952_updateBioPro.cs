using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeoShared.Migrations
{
    /// <inheritdoc />
    public partial class updateBioPro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Provincia_Bioma_Biomasname",
                table: "Provincia");

            migrationBuilder.DropIndex(
                name: "IX_Provincia_Biomasname",
                table: "Provincia");

            migrationBuilder.DropColumn(
                name: "Biomasname",
                table: "Provincia");

            migrationBuilder.DropColumn(
                name: "provincia",
                table: "Governador");

            migrationBuilder.AlterColumn<string>(
                name: "Bioma",
                table: "Provincia",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "provinciaName",
                table: "Governador",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Provincia_Bioma",
                table: "Provincia",
                column: "Bioma");

            migrationBuilder.CreateIndex(
                name: "IX_Governador_provinciaName",
                table: "Governador",
                column: "provinciaName");

            migrationBuilder.AddForeignKey(
                name: "FK_Governador_Provincia_provinciaName",
                table: "Governador",
                column: "provinciaName",
                principalTable: "Provincia",
                principalColumn: "code",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Provincia_Bioma_Bioma",
                table: "Provincia",
                column: "Bioma",
                principalTable: "Bioma",
                principalColumn: "name",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Governador_Provincia_provinciaName",
                table: "Governador");

            migrationBuilder.DropForeignKey(
                name: "FK_Provincia_Bioma_Bioma",
                table: "Provincia");

            migrationBuilder.DropIndex(
                name: "IX_Provincia_Bioma",
                table: "Provincia");

            migrationBuilder.DropIndex(
                name: "IX_Governador_provinciaName",
                table: "Governador");

            migrationBuilder.DropColumn(
                name: "provinciaName",
                table: "Governador");

            migrationBuilder.AlterColumn<string>(
                name: "Bioma",
                table: "Provincia",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Biomasname",
                table: "Provincia",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "provincia",
                table: "Governador",
                type: "longtext",
                nullable: false)
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
    }
}
