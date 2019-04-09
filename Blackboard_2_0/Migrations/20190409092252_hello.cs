using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blackboard_2_0.Migrations
{
    public partial class hello : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "EventId",
                keyValue: 1,
                column: "EventDate",
                value: new DateTime(2019, 4, 19, 11, 22, 51, 621, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "EventId",
                keyValue: 2,
                column: "EventDate",
                value: new DateTime(2019, 4, 13, 15, 22, 51, 621, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "EventId",
                keyValue: 3,
                column: "EventDate",
                value: new DateTime(2019, 4, 29, 11, 22, 51, 621, DateTimeKind.Local).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "EventId",
                keyValue: 4,
                column: "EventDate",
                value: new DateTime(2019, 4, 11, 11, 22, 51, 621, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Birthday", "EnrolledDate", "GraduationDate" },
                values: new object[] { new DateTime(2019, 4, 9, 11, 22, 51, 615, DateTimeKind.Local).AddTicks(4359), new DateTime(2019, 3, 30, 11, 22, 51, 617, DateTimeKind.Local).AddTicks(6450), new DateTime(2020, 3, 24, 11, 22, 51, 617, DateTimeKind.Local).AddTicks(7124) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Birthday", "EnrolledDate", "GraduationDate" },
                values: new object[] { new DateTime(2016, 7, 13, 11, 22, 51, 617, DateTimeKind.Local).AddTicks(8888), new DateTime(2018, 12, 30, 11, 22, 51, 617, DateTimeKind.Local).AddTicks(8905), new DateTime(2019, 12, 15, 11, 22, 51, 617, DateTimeKind.Local).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Birthday",
                value: new DateTime(2017, 11, 25, 11, 22, 51, 618, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4,
                column: "Birthday",
                value: new DateTime(2016, 7, 13, 11, 22, 51, 618, DateTimeKind.Local).AddTicks(2431));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
