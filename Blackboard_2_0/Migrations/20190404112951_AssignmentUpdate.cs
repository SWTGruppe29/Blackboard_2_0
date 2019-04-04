using Microsoft.EntityFrameworkCore.Migrations;

namespace Blackboard_2_0.Migrations
{
    public partial class AssignmentUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaxAssigners",
                table: "Assignments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Assignments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxAssigners",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Assignments");
        }
    }
}
