using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blackboard_2_0.Migrations
{
    public partial class AddedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AuIds",
                columns: new[] { "Id", "Role" },
                values: new object[,]
                {
                    { 1, "Student" },
                    { 2, "Student" },
                    { 3, "Teacher" },
                    { 4, "Teacher" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Name" },
                values: new object[,]
                {
                    { 1, "I4DAB" },
                    { 2, "I4GUI" },
                    { 3, "I4SWD" }
                });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "AssignmentId", "CourseId", "MaxAssigners", "Name" },
                values: new object[,]
                {
                    { 1, 1, 4, "EF Core Assignment" },
                    { 2, 1, 1, "SQL Server BB2" },
                    { 3, 2, 1, "JavaJam" },
                    { 4, 3, 3, "GUI Assignment" }
                });

            migrationBuilder.InsertData(
                table: "Calendars",
                columns: new[] { "EventId", "CourseId", "EventDate", "EventName", "Type" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2019, 4, 18, 12, 57, 23, 715, DateTimeKind.Local).AddTicks(6750), "Aflevering", "Deadline" },
                    { 2, 2, new DateTime(2019, 4, 12, 16, 57, 23, 715, DateTimeKind.Local).AddTicks(8318), "Undervisning", "Lecture" },
                    { 3, 2, new DateTime(2019, 4, 28, 12, 57, 23, 715, DateTimeKind.Local).AddTicks(8333), "Opgaver", "Group work" },
                    { 4, 3, new DateTime(2019, 4, 10, 12, 57, 23, 715, DateTimeKind.Local).AddTicks(8338), "Forelæsning", "Lecture" }
                });

            migrationBuilder.InsertData(
                table: "CourseContents",
                columns: new[] { "CourseContentId", "CourseId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "EF Core" },
                    { 3, 1, "SQL" },
                    { 2, 2, "MVC" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Birthday", "EnrolledDate", "FirstName", "GraduationDate", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 4, 8, 12, 57, 23, 710, DateTimeKind.Local).AddTicks(4753), new DateTime(2019, 3, 29, 12, 57, 23, 713, DateTimeKind.Local).AddTicks(2358), "Thomas", new DateTime(2020, 3, 23, 12, 57, 23, 713, DateTimeKind.Local).AddTicks(2878), "Moeller" },
                    { 2, new DateTime(2016, 7, 12, 12, 57, 23, 713, DateTimeKind.Local).AddTicks(4158), new DateTime(2018, 12, 29, 12, 57, 23, 713, DateTimeKind.Local).AddTicks(4173), "Oskar", new DateTime(2019, 12, 14, 12, 57, 23, 713, DateTimeKind.Local).AddTicks(4178), "Hansen" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Birthday", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 3, new DateTime(2017, 11, 24, 12, 57, 23, 713, DateTimeKind.Local).AddTicks(5504), "Mathias", "Thomassen" },
                    { 4, new DateTime(2016, 7, 12, 12, 57, 23, 713, DateTimeKind.Local).AddTicks(6666), "Valdemar", "Tang" }
                });

            migrationBuilder.InsertData(
                table: "Assignerses",
                columns: new[] { "AssignersId", "AssignmentId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Gruppe 12!" },
                    { 2, 3, "Gruppe 11" },
                    { 3, 2, "Gruppe 1" },
                    { 4, 1, "Gruppe 15!" },
                    { 5, 4, "Gruppe 22" }
                });

            migrationBuilder.InsertData(
                table: "Attends",
                columns: new[] { "StudentId", "CourseId", "Status" },
                values: new object[,]
                {
                    { 2, 1, "Passed" },
                    { 2, 2, "Active" },
                    { 1, 2, "Failed" },
                    { 1, 1, "Active" }
                });

            migrationBuilder.InsertData(
                table: "ContentAreas",
                columns: new[] { "ContentAreaId", "CourseContentId", "FolderId", "TextBlock" },
                values: new object[,]
                {
                    { 1, 1, null, "Migrationzzzzz.........." },
                    { 3, 2, null, "Kig her!" }
                });

            migrationBuilder.InsertData(
                table: "Folders",
                columns: new[] { "FolderId", "CourseContentId", "FolderName" },
                values: new object[,]
                {
                    { 3, 2, "Presentation" },
                    { 1, 1, "Examples" },
                    { 2, 1, "Slides" }
                });

            migrationBuilder.InsertData(
                table: "Teaches",
                columns: new[] { "AuId", "CourseId", "Role" },
                values: new object[,]
                {
                    { 3, 2, "Assistant Teacher" },
                    { 4, 2, "Teacher" },
                    { 4, 3, "Teacher" },
                    { 3, 1, "Teacher" }
                });

            migrationBuilder.InsertData(
                table: "ContentAreas",
                columns: new[] { "ContentAreaId", "CourseContentId", "FolderId", "TextBlock" },
                values: new object[,]
                {
                    { 2, 3, 1, "Insert, delete update...." },
                    { 4, 1, 2, "Kan snart ikke finde på mere" }
                });

            migrationBuilder.InsertData(
                table: "ContentLinks",
                columns: new[] { "ContentLinkId", "ContentAreaId", "ContentUri", "Type" },
                values: new object[,]
                {
                    { 1, 1, "https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/", "WebPage" },
                    { 3, 3, "https://www.youtube.com/watch?v=tEId2k4wu6w", null }
                });

            migrationBuilder.InsertData(
                table: "HandIns",
                columns: new[] { "AssignersId", "AssignmentId", "Grade", "GraderId", "Text" },
                values: new object[,]
                {
                    { 1, 1, "12", 3, "Dette er handin 1 for gruppe 12" },
                    { 4, 1, "02", 4, "Meh" },
                    { 3, 2, "4", 3, "Øvv" },
                    { 2, 3, "-3", 4, "Handin for gruppe 11" },
                    { 5, 4, "10", 4, "Godt forsøg" }
                });

            migrationBuilder.InsertData(
                table: "StudentAssignerses",
                columns: new[] { "StudentId", "AssignersId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 2, 5 },
                    { 1, 5 }
                });

            migrationBuilder.InsertData(
                table: "ContentLinks",
                columns: new[] { "ContentLinkId", "ContentAreaId", "ContentUri", "Type" },
                values: new object[] { 2, 2, "https://www.youtube.com/watch?v=dQw4w9WgXcQ", null });

            migrationBuilder.InsertData(
                table: "ContentLinks",
                columns: new[] { "ContentLinkId", "ContentAreaId", "ContentUri", "Type" },
                values: new object[] { 4, 2, "https://www.youtube.com/watch?v=DtJgNvwmsRA", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Attends",
                keyColumns: new[] { "StudentId", "CourseId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Attends",
                keyColumns: new[] { "StudentId", "CourseId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Attends",
                keyColumns: new[] { "StudentId", "CourseId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Attends",
                keyColumns: new[] { "StudentId", "CourseId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "EventId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "EventId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "EventId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "EventId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ContentAreas",
                keyColumn: "ContentAreaId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ContentLinks",
                keyColumn: "ContentLinkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ContentLinks",
                keyColumn: "ContentLinkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ContentLinks",
                keyColumn: "ContentLinkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ContentLinks",
                keyColumn: "ContentLinkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Folders",
                keyColumn: "FolderId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HandIns",
                keyColumns: new[] { "AssignersId", "AssignmentId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "HandIns",
                keyColumns: new[] { "AssignersId", "AssignmentId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "HandIns",
                keyColumns: new[] { "AssignersId", "AssignmentId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "HandIns",
                keyColumns: new[] { "AssignersId", "AssignmentId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "HandIns",
                keyColumns: new[] { "AssignersId", "AssignmentId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "StudentAssignerses",
                keyColumns: new[] { "StudentId", "AssignersId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "StudentAssignerses",
                keyColumns: new[] { "StudentId", "AssignersId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "StudentAssignerses",
                keyColumns: new[] { "StudentId", "AssignersId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "StudentAssignerses",
                keyColumns: new[] { "StudentId", "AssignersId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "StudentAssignerses",
                keyColumns: new[] { "StudentId", "AssignersId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "StudentAssignerses",
                keyColumns: new[] { "StudentId", "AssignersId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "Teaches",
                keyColumns: new[] { "AuId", "CourseId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Teaches",
                keyColumns: new[] { "AuId", "CourseId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Teaches",
                keyColumns: new[] { "AuId", "CourseId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "Teaches",
                keyColumns: new[] { "AuId", "CourseId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "Assignerses",
                keyColumn: "AssignersId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Assignerses",
                keyColumn: "AssignersId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Assignerses",
                keyColumn: "AssignersId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Assignerses",
                keyColumn: "AssignersId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Assignerses",
                keyColumn: "AssignersId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ContentAreas",
                keyColumn: "ContentAreaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ContentAreas",
                keyColumn: "ContentAreaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ContentAreas",
                keyColumn: "ContentAreaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Folders",
                keyColumn: "FolderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AuIds",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AuIds",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AuIds",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AuIds",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CourseContents",
                keyColumn: "CourseContentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CourseContents",
                keyColumn: "CourseContentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Folders",
                keyColumn: "FolderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CourseContents",
                keyColumn: "CourseContentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1);
        }
    }
}
