using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductBacklog.Api.Migrations
{
    public partial class AddDefaultValueToProjectCreatedAt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "Projects",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2019, 2, 12, 14, 52, 12, 939, DateTimeKind.Unspecified).AddTicks(486), new TimeSpan(0, -2, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "Projects",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValue: new DateTimeOffset(new DateTime(2019, 2, 12, 14, 52, 12, 939, DateTimeKind.Unspecified).AddTicks(486), new TimeSpan(0, -2, 0, 0, 0)));
        }
    }
}
