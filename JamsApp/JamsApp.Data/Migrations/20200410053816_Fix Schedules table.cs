using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JamsApp.Data.Migrations
{
    public partial class FixSchedulestable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FecHour",
                table: "Assistances");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Schedules",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "FecCreation",
                table: "Assistances",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FecCreation",
                table: "Assistances");

            migrationBuilder.AlterColumn<int>(
                name: "Description",
                table: "Schedules",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AddColumn<DateTime>(
                name: "FecHour",
                table: "Assistances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
