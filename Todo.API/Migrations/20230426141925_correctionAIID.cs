using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Todo.API.Migrations
{
    /// <inheritdoc />
    public partial class correctionAIID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "tb_person",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 26, 11, 19, 25, 120, DateTimeKind.Local).AddTicks(9971),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2023, 4, 25, 14, 56, 4, 423, DateTimeKind.Local).AddTicks(2553));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "tb_person",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 25, 14, 56, 4, 423, DateTimeKind.Local).AddTicks(2553),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2023, 4, 26, 11, 19, 25, 120, DateTimeKind.Local).AddTicks(9971));
        }
    }
}
