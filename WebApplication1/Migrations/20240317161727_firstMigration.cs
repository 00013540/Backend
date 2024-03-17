using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class firstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    DueDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: true),
                    Priority = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTasks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "UserTasks",
                columns: new[] { "Id", "Description", "DueDate", "Priority", "Status", "Title" },
                values: new object[,]
                {
                    { 1, "Finish writing the project proposal document.", new DateTimeOffset(new DateTime(2024, 3, 24, 21, 17, 26, 596, DateTimeKind.Unspecified).AddTicks(3458), new TimeSpan(0, 5, 0, 0, 0)), 0, 1, "Complete project proposal" },
                    { 2, "Discuss project requirements with the client.", new DateTimeOffset(new DateTime(2024, 3, 20, 21, 17, 26, 596, DateTimeKind.Unspecified).AddTicks(3503), new TimeSpan(0, 5, 0, 0, 0)), 1, 2, "Meeting with client" },
                    { 3, "Create a presentation for the project update meeting.", new DateTimeOffset(new DateTime(2024, 3, 27, 21, 17, 26, 596, DateTimeKind.Unspecified).AddTicks(3506), new TimeSpan(0, 5, 0, 0, 0)), 2, 3, "Prepare presentation" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserTasks");
        }
    }
}
