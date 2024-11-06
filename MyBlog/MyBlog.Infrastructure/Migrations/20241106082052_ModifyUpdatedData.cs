using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModifyUpdatedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Local) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 10, 28, 15, 52, 46, 214, DateTimeKind.Local).AddTicks(377), new DateTime(2024, 10, 28, 15, 52, 46, 214, DateTimeKind.Local).AddTicks(386) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 10, 28, 15, 52, 46, 214, DateTimeKind.Local).AddTicks(415), new DateTime(2024, 10, 28, 15, 52, 46, 214, DateTimeKind.Local).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 10, 28, 15, 52, 46, 214, DateTimeKind.Local).AddTicks(411), new DateTime(2024, 10, 28, 15, 52, 46, 214, DateTimeKind.Local).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 10, 28, 15, 52, 46, 214, DateTimeKind.Local).AddTicks(401), new DateTime(2024, 10, 28, 15, 52, 46, 214, DateTimeKind.Local).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 10, 28, 15, 52, 46, 214, DateTimeKind.Local).AddTicks(393), new DateTime(2024, 10, 28, 15, 52, 46, 214, DateTimeKind.Local).AddTicks(393) });
        }
    }
}
