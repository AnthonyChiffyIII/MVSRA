using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVSRA.Server.EFContext.Migrations
{
    /// <inheritdoc />
    public partial class AddBaseModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UploadedBy",
                schema: "MVSRA",
                table: "PhotoGallery",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FileType",
                schema: "MVSRA",
                table: "PhotoGallery",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "ActiveOfficers",
                schema: "MVSRA",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UploadDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UploadedBy = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActiveOfficers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HotInformation",
                schema: "MVSRA",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    News = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UploadDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UploadedBy = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotInformation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Leagues",
                schema: "MVSRA",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ScheduleURL = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    RulesURL = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Contact = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UploadDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UploadedBy = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leagues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                schema: "MVSRA",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DirectionsURL = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    UploadDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UploadedBy = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meetings",
                schema: "MVSRA",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Time = table.Column<TimeOnly>(type: "time", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Attendees = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Agenda = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    MeetingNotesURL = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    UploadDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UploadedBy = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meetings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhotoGallery_HomePage",
                schema: "MVSRA",
                columns: table => new
                {
                    PhotosId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoGallery_HomePage", x => x.PhotosId);
                    table.ForeignKey(
                        name: "FK_PhotoGallery_HomePage_PhotoGallery_PhotosId",
                        column: x => x.PhotosId,
                        principalSchema: "MVSRA",
                        principalTable: "PhotoGallery",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhotoGallery_Locations",
                schema: "MVSRA",
                columns: table => new
                {
                    LocationsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhotosId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoGallery_Locations", x => new { x.LocationsId, x.PhotosId });
                    table.ForeignKey(
                        name: "FK_PhotoGallery_Locations_Locations_LocationsId",
                        column: x => x.LocationsId,
                        principalSchema: "MVSRA",
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhotoGallery_Locations_PhotoGallery_PhotosId",
                        column: x => x.PhotosId,
                        principalSchema: "MVSRA",
                        principalTable: "PhotoGallery",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhotoGallery_Locations_PhotosId",
                schema: "MVSRA",
                table: "PhotoGallery_Locations",
                column: "PhotosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActiveOfficers",
                schema: "MVSRA");

            migrationBuilder.DropTable(
                name: "HotInformation",
                schema: "MVSRA");

            migrationBuilder.DropTable(
                name: "Leagues",
                schema: "MVSRA");

            migrationBuilder.DropTable(
                name: "Meetings",
                schema: "MVSRA");

            migrationBuilder.DropTable(
                name: "PhotoGallery_HomePage",
                schema: "MVSRA");

            migrationBuilder.DropTable(
                name: "PhotoGallery_Locations",
                schema: "MVSRA");

            migrationBuilder.DropTable(
                name: "Locations",
                schema: "MVSRA");

            migrationBuilder.AlterColumn<string>(
                name: "UploadedBy",
                schema: "MVSRA",
                table: "PhotoGallery",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "FileType",
                schema: "MVSRA",
                table: "PhotoGallery",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }
    }
}
