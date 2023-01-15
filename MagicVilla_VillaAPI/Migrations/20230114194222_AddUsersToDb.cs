using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVillaVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddUsersToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LocalUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsreName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalUsers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2023, 1, 14, 23, 12, 22, 467, DateTimeKind.Local).AddTicks(3896), "https://dotnetmastery.com/bluevillaimages/villa3.jpg" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2023, 1, 14, 23, 12, 22, 467, DateTimeKind.Local).AddTicks(3945), "https://dotnetmastery.com/bluevillaimages/villa1.jpg" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2023, 1, 14, 23, 12, 22, 467, DateTimeKind.Local).AddTicks(3952), "https://dotnetmastery.com/bluevillaimages/villa4.jpg" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2023, 1, 14, 23, 12, 22, 467, DateTimeKind.Local).AddTicks(3957), "https://dotnetmastery.com/bluevillaimages/villa5.jpg" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2023, 1, 14, 23, 12, 22, 467, DateTimeKind.Local).AddTicks(3962), "https://dotnetmastery.com/bluevillaimages/villa2.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocalUsers");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2023, 1, 13, 0, 12, 30, 930, DateTimeKind.Local).AddTicks(8003), "https://images.freeimages.com/images/large-previews/ec1/rain-drops-grass-nature-1642017.jpg" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2023, 1, 13, 0, 12, 30, 930, DateTimeKind.Local).AddTicks(8073), "https://images.freeimages.com/images/large-previews/ec1/rain-drops-grass-nature-1642017.jpg" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2023, 1, 13, 0, 12, 30, 930, DateTimeKind.Local).AddTicks(8079), "https://images.freeimages.com/images/large-previews/ec1/rain-drops-grass-nature-1642017.jpg" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2023, 1, 13, 0, 12, 30, 930, DateTimeKind.Local).AddTicks(8085), "https://images.freeimages.com/images/large-previews/ec1/rain-drops-grass-nature-1642017.jpg" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2023, 1, 13, 0, 12, 30, 930, DateTimeKind.Local).AddTicks(8090), "https://images.freeimages.com/images/large-previews/ec1/rain-drops-grass-nature-1642017.jpg" });
        }
    }
}
