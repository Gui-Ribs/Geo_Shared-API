using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeoShared.Migrations
{
    /// <inheritdoc />
    public partial class updateProv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Quiz",
                newName: "code");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "code",
                table: "Quiz",
                newName: "name");
        }
    }
}
