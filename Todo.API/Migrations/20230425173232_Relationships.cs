using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Todo.API.Migrations
{
    /// <inheritdoc />
    public partial class Relationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_todotask",
                table: "tb_todotask");

            migrationBuilder.RenameTable(
                name: "tb_todotask",
                newName: "tb_todo_task");

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_login",
                table: "tb_person",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "tb_person",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 25, 14, 32, 32, 378, DateTimeKind.Local).AddTicks(7439),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 4, 25, 13, 0, 26, 23, DateTimeKind.Local).AddTicks(174));

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "tb_email_confirm",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "task_finished_date",
                table: "tb_todo_task",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "task_datetime",
                table: "tb_todo_task",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddColumn<int>(
                name: "id_person",
                table: "tb_todo_task",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_todo_task",
                table: "tb_todo_task",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_email_confirm_PersonId",
                table: "tb_email_confirm",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_todo_task_id_person",
                table: "tb_todo_task",
                column: "id_person");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_email_confirm_tb_person_PersonId",
                table: "tb_email_confirm",
                column: "PersonId",
                principalTable: "tb_person",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_todo_task_tb_person_id_person",
                table: "tb_todo_task",
                column: "id_person",
                principalTable: "tb_person",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_email_confirm_tb_person_PersonId",
                table: "tb_email_confirm");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_todo_task_tb_person_id_person",
                table: "tb_todo_task");

            migrationBuilder.DropIndex(
                name: "IX_tb_email_confirm_PersonId",
                table: "tb_email_confirm");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_todo_task",
                table: "tb_todo_task");

            migrationBuilder.DropIndex(
                name: "IX_tb_todo_task_id_person",
                table: "tb_todo_task");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "tb_email_confirm");

            migrationBuilder.DropColumn(
                name: "id_person",
                table: "tb_todo_task");

            migrationBuilder.RenameTable(
                name: "tb_todo_task",
                newName: "tb_todotask");

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_login",
                table: "tb_person",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "tb_person",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 25, 13, 0, 26, 23, DateTimeKind.Local).AddTicks(174),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2023, 4, 25, 14, 32, 32, 378, DateTimeKind.Local).AddTicks(7439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "task_finished_date",
                table: "tb_todotask",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "task_datetime",
                table: "tb_todotask",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_todotask",
                table: "tb_todotask",
                column: "id");
        }
    }
}
