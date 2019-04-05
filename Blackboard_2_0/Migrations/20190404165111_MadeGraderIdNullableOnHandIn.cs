using Microsoft.EntityFrameworkCore.Migrations;

namespace Blackboard_2_0.Migrations
{
    public partial class MadeGraderIdNullableOnHandIn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HandIns_Teachers_GraderId",
                table: "HandIns");

            migrationBuilder.AlterColumn<int>(
                name: "GraderId",
                table: "HandIns",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_HandIns_Teachers_GraderId",
                table: "HandIns",
                column: "GraderId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HandIns_Teachers_GraderId",
                table: "HandIns");

            migrationBuilder.AlterColumn<int>(
                name: "GraderId",
                table: "HandIns",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_HandIns_Teachers_GraderId",
                table: "HandIns",
                column: "GraderId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
