using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class add_subtitle_and_imagepreview_column : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePreview",
                table: "Posts",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subtitle",
                table: "Posts",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "Created", "ImagePreview", "Subtitle", "Updated" },
                values: new object[] { new DateTime(2024, 10, 28, 15, 52, 46, 214, DateTimeKind.Local).AddTicks(415), null, "This is my second post", new DateTime(2024, 10, 28, 15, 52, 46, 214, DateTimeKind.Local).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Created", "ImagePreview", "Subtitle", "Updated" },
                values: new object[] { new DateTime(2024, 10, 28, 15, 52, 46, 214, DateTimeKind.Local).AddTicks(411), null, "This is my first post", new DateTime(2024, 10, 28, 15, 52, 46, 214, DateTimeKind.Local).AddTicks(412) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePreview",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Subtitle",
                table: "Posts");

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 8, 17, 22, 25, 2, 420, DateTimeKind.Local).AddTicks(267), new DateTime(2024, 8, 17, 22, 25, 2, 420, DateTimeKind.Local).AddTicks(278) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 8, 17, 22, 25, 2, 420, DateTimeKind.Local).AddTicks(318), new DateTime(2024, 8, 17, 22, 25, 2, 420, DateTimeKind.Local).AddTicks(319) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 8, 17, 22, 25, 2, 420, DateTimeKind.Local).AddTicks(314), new DateTime(2024, 8, 17, 22, 25, 2, 420, DateTimeKind.Local).AddTicks(314) });

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 8, 17, 22, 25, 2, 420, DateTimeKind.Local).AddTicks(306), new DateTime(2024, 8, 17, 22, 25, 2, 420, DateTimeKind.Local).AddTicks(307) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 8, 17, 22, 25, 2, 420, DateTimeKind.Local).AddTicks(296), new DateTime(2024, 8, 17, 22, 25, 2, 420, DateTimeKind.Local).AddTicks(296) });
        }
    }
}
