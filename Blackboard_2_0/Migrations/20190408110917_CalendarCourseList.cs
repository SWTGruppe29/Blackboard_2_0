using Microsoft.EntityFrameworkCore.Migrations;

namespace Blackboard_2_0.Migrations
{
    public partial class CalendarCourseList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calendars_Courses_CourseId",
                table: "Calendars");

            migrationBuilder.AddColumn<int>(
                name: "CalendarEventId",
                table: "Courses",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddForeignKey(
                name: "FK_Calendars_Courses_CourseId",
                table: "Calendars",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
