using Microsoft.EntityFrameworkCore.Migrations;

namespace Blackboard_2_0.Migrations
{
    public partial class ChangedContentArea : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignerses_Assignments_AssignmentId",
                table: "Assignerses");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignerses_Assignments_AssignmentId",
                table: "Assignerses",
                column: "AssignmentId",
                principalTable: "Assignments",
                principalColumn: "AssignmentId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignerses_Assignments_AssignmentId",
                table: "Assignerses");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignerses_Assignments_AssignmentId",
                table: "Assignerses",
                column: "AssignmentId",
                principalTable: "Assignments",
                principalColumn: "AssignmentId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
