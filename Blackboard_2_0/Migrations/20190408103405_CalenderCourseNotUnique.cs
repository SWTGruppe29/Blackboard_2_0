using Microsoft.EntityFrameworkCore.Migrations;

namespace Blackboard_2_0.Migrations
{
    public partial class CalenderCourseNotUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Calendars_CourseId",
                table: "Calendars");

            migrationBuilder.CreateIndex(
                name: "IX_Calendars_CourseId",
                table: "Calendars",
                column: "CourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Calendars_CourseId",
                table: "Calendars");

            migrationBuilder.CreateIndex(
                name: "IX_Calendars_CourseId",
                table: "Calendars",
                column: "CourseId",
                unique: true);
        }
    }
}
