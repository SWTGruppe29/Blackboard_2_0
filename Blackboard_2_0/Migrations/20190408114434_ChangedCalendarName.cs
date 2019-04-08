using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blackboard_2_0.Migrations
{
    public partial class ChangedCalendarName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "EventId",
                keyValue: 1,
                column: "EventDate",
                value: new DateTime(2019, 4, 18, 13, 44, 32, 806, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "EventId",
                keyValue: 2,
                column: "EventDate",
                value: new DateTime(2019, 4, 12, 17, 44, 32, 812, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "EventId",
                keyValue: 3,
                column: "EventDate",
                value: new DateTime(2019, 4, 28, 13, 44, 32, 812, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "EventId",
                keyValue: 4,
                column: "EventDate",
                value: new DateTime(2019, 4, 10, 13, 44, 32, 812, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Birthday", "EnrolledDate", "GraduationDate" },
                values: new object[] { new DateTime(2019, 4, 8, 13, 44, 32, 796, DateTimeKind.Local).AddTicks(9741), new DateTime(2019, 3, 29, 13, 44, 32, 800, DateTimeKind.Local).AddTicks(2222), new DateTime(2020, 3, 23, 13, 44, 32, 800, DateTimeKind.Local).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Birthday", "EnrolledDate", "GraduationDate" },
                values: new object[] { new DateTime(2016, 7, 12, 13, 44, 32, 800, DateTimeKind.Local).AddTicks(5728), new DateTime(2018, 12, 29, 13, 44, 32, 800, DateTimeKind.Local).AddTicks(5756), new DateTime(2019, 12, 14, 13, 44, 32, 800, DateTimeKind.Local).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Birthday",
                value: new DateTime(2017, 11, 24, 13, 44, 32, 800, DateTimeKind.Local).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4,
                column: "Birthday",
                value: new DateTime(2016, 7, 12, 13, 44, 32, 801, DateTimeKind.Local).AddTicks(1933));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "EventId",
                keyValue: 1,
                column: "EventDate",
                value: new DateTime(2019, 4, 18, 13, 37, 19, 255, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "EventId",
                keyValue: 2,
                column: "EventDate",
                value: new DateTime(2019, 4, 12, 17, 37, 19, 256, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "EventId",
                keyValue: 3,
                column: "EventDate",
                value: new DateTime(2019, 4, 28, 13, 37, 19, 256, DateTimeKind.Local).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "EventId",
                keyValue: 4,
                column: "EventDate",
                value: new DateTime(2019, 4, 10, 13, 37, 19, 256, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Birthday", "EnrolledDate", "GraduationDate" },
                values: new object[] { new DateTime(2019, 4, 8, 13, 37, 19, 248, DateTimeKind.Local).AddTicks(9598), new DateTime(2019, 3, 29, 13, 37, 19, 251, DateTimeKind.Local).AddTicks(7494), new DateTime(2020, 3, 23, 13, 37, 19, 251, DateTimeKind.Local).AddTicks(8305) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Birthday", "EnrolledDate", "GraduationDate" },
                values: new object[] { new DateTime(2016, 7, 12, 13, 37, 19, 252, DateTimeKind.Local).AddTicks(363), new DateTime(2018, 12, 29, 13, 37, 19, 252, DateTimeKind.Local).AddTicks(384), new DateTime(2019, 12, 14, 13, 37, 19, 252, DateTimeKind.Local).AddTicks(397) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Birthday",
                value: new DateTime(2017, 11, 24, 13, 37, 19, 252, DateTimeKind.Local).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4,
                column: "Birthday",
                value: new DateTime(2016, 7, 12, 13, 37, 19, 252, DateTimeKind.Local).AddTicks(4552));
        }
    }
}
