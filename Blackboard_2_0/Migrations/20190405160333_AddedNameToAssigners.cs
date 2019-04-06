using Microsoft.EntityFrameworkCore.Migrations;

namespace Blackboard_2_0.Migrations
{
    public partial class AddedNameToAssigners : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Folders_Folders_ParentFolderId",
            //    table: "Folders");

            //migrationBuilder.DropIndex(
            //    name: "IX_Folders_ParentFolderId",
            //    table: "Folders");

            //migrationBuilder.DropColumn(
            //    name: "ParentFolderId",
            //    table: "Folders");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Assignerses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Assignerses");

            //migrationBuilder.AddColumn<int>(
            //    name: "ParentFolderId",
            //    table: "Folders",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Folders_ParentFolderId",
            //    table: "Folders",
            //    column: "ParentFolderId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Folders_Folders_ParentFolderId",
            //    table: "Folders",
            //    column: "ParentFolderId",
            //    principalTable: "Folders",
            //    principalColumn: "FolderId",
            //    onDelete: ReferentialAction.Cascade);
        }
    }
}
