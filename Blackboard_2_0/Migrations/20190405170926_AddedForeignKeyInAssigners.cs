using Microsoft.EntityFrameworkCore.Migrations;

namespace Blackboard_2_0.Migrations
{
    public partial class AddedForeignKeyInAssigners : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssignmentId",
                table: "Assignerses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Assignerses_AssignmentId",
                table: "Assignerses", 
                column: "AssignmentId");

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

            migrationBuilder.DropIndex(
                name: "IX_Assignerses_AssignmentId",
                table: "Assignerses");

            migrationBuilder.DropColumn(
                name: "AssignmentId",
                table: "Assignerses");
        }
    }
}
