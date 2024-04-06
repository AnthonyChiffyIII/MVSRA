using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVSRA.EFContext.Migrations
{
    /// <inheritdoc />
    public partial class FileTypeColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileType",
                table: "PhotoGallery",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileType",
                table: "PhotoGallery");
        }
    }
}
