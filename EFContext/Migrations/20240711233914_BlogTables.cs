using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVSRA.Server.EFContext.Migrations
{
    /// <inheritdoc />
    public partial class BlogTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogComments",
                schema: "MVSRA",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DatabaseCreationTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatabaseModificationTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogComments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogCommunities",
                schema: "MVSRA",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ForumId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    CreatingUserId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DatabaseCreationTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatabaseModificationTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogCommunities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogPosts",
                schema: "MVSRA",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommunityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DatabaseCreationTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatabaseModificationTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogComments",
                schema: "MVSRA");

            migrationBuilder.DropTable(
                name: "BlogCommunities",
                schema: "MVSRA");

            migrationBuilder.DropTable(
                name: "BlogPosts",
                schema: "MVSRA");
        }
    }
}
