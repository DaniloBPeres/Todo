using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Todo.API.Migrations
{
    /// <inheritdoc />
    public partial class RelationshipsAtt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_email_confirm_tb_person_PersonId",
                table: "tb_email_confirm");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "tb_email_confirm",
                newName: "id_person");

            migrationBuilder.RenameIndex(
                name: "IX_tb_email_confirm_PersonId",
                table: "tb_email_confirm",
                newName: "IX_tb_email_confirm_id_person");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "tb_person",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 25, 14, 36, 45, 137, DateTimeKind.Local).AddTicks(1258),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2023, 4, 25, 14, 32, 32, 378, DateTimeKind.Local).AddTicks(7439));

            migrationBuilder.AddForeignKey(
                name: "FK_tb_email_confirm_tb_person_id_person",
                table: "tb_email_confirm",
                column: "id_person",
                principalTable: "tb_person",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_email_confirm_tb_person_id_person",
                table: "tb_email_confirm");

            migrationBuilder.RenameColumn(
                name: "id_person",
                table: "tb_email_confirm",
                newName: "PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_tb_email_confirm_id_person",
                table: "tb_email_confirm",
                newName: "IX_tb_email_confirm_PersonId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "tb_person",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 25, 14, 32, 32, 378, DateTimeKind.Local).AddTicks(7439),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2023, 4, 25, 14, 36, 45, 137, DateTimeKind.Local).AddTicks(1258));

            migrationBuilder.AddForeignKey(
                name: "FK_tb_email_confirm_tb_person_PersonId",
                table: "tb_email_confirm",
                column: "PersonId",
                principalTable: "tb_person",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
