using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blackboard_2_0.Migrations
{
    public partial class OneToManyCourseCalendar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Calendars_CalendarEventId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CalendarEventId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CalendarEventId",
                table: "Courses");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Calendars_Courses_CourseId",
                table: "Calendars",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calendars_Courses_CourseId",
                table: "Calendars");

            migrationBuilder.AddColumn<int>(
                name: "CalendarEventId",
                table: "Courses",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "EventId",
                keyValue: 1,
                column: "EventDate",
                value: new DateTime(2019, 4, 18, 12, 57, 23, 715, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "EventId",
                keyValue: 2,
                column: "EventDate",
                value: new DateTime(2019, 4, 12, 16, 57, 23, 715, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "EventId",
                keyValue: 3,
                column: "EventDate",
                value: new DateTime(2019, 4, 28, 12, 57, 23, 715, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "EventId",
                keyValue: 4,
                column: "EventDate",
                value: new DateTime(2019, 4, 10, 12, 57, 23, 715, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Birthday", "EnrolledDate", "GraduationDate" },
                values: new object[] { new DateTime(2019, 4, 8, 12, 57, 23, 710, DateTimeKind.Local).AddTicks(4753), new DateTime(2019, 3, 29, 12, 57, 23, 713, DateTimeKind.Local).AddTicks(2358), new DateTime(2020, 3, 23, 12, 57, 23, 713, DateTimeKind.Local).AddTicks(2878) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Birthday", "EnrolledDate", "GraduationDate" },
                values: new object[] { new DateTime(2016, 7, 12, 12, 57, 23, 713, DateTimeKind.Local).AddTicks(4158), new DateTime(2018, 12, 29, 12, 57, 23, 713, DateTimeKind.Local).AddTicks(4173), new DateTime(2019, 12, 14, 12, 57, 23, 713, DateTimeKind.Local).AddTicks(4178) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Birthday",
                value: new DateTime(2017, 11, 24, 12, 57, 23, 713, DateTimeKind.Local).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4,
                column: "Birthday",
                value: new DateTime(2016, 7, 12, 12, 57, 23, 713, DateTimeKind.Local).AddTicks(6666));

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CalendarEventId",
                table: "Courses",
                column: "CalendarEventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Calendars_CalendarEventId",
                table: "Courses",
                column: "CalendarEventId",
                principalTable: "Calendars",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
