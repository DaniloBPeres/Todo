using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Todo.API.Migrations
{
    /// <inheritdoc />
    public partial class correctionMap : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "tb_person",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 26, 14, 35, 6, 339, DateTimeKind.Local).AddTicks(2565),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2023, 4, 26, 14, 22, 10, 397, DateTimeKind.Local).AddTicks(1336));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "tb_person",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 26, 14, 22, 10, 397, DateTimeKind.Local).AddTicks(1336),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2023, 4, 26, 14, 35, 6, 339, DateTimeKind.Local).AddTicks(2565));
        }
    }
}
