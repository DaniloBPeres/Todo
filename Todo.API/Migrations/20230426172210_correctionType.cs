using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Todo.API.Migrations
{
    /// <inheritdoc />
    public partial class correctionType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "tb_person",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 26, 14, 22, 10, 397, DateTimeKind.Local).AddTicks(1336),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2023, 4, 26, 11, 19, 25, 120, DateTimeKind.Local).AddTicks(9971));

            migrationBuilder.AlterColumn<string>(
                name: "code_to_confirm",
                table: "tb_email_confirm",
                type: "text",
                precision: 6,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldPrecision: 6);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "tb_person",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 26, 11, 19, 25, 120, DateTimeKind.Local).AddTicks(9971),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2023, 4, 26, 14, 22, 10, 397, DateTimeKind.Local).AddTicks(1336));

            migrationBuilder.AlterColumn<int>(
                name: "code_to_confirm",
                table: "tb_email_confirm",
                type: "integer",
                precision: 6,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldPrecision: 6);
        }
    }
}
