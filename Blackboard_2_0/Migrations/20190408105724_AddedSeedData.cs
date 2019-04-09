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
                    { 3, "Student" },
                    { 4, "Student" },
                    { 5, "Teacher" },
                    { 6, "Teacher" },
                    { 7, "Teacher" },
                    { 8, "Teacher" },
                    { 9, "Student" },
                    { 10, "Student" },
                });


            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Name" },
                values: new object[,]
                {
                    { 1, "I4DAB" },
                    { 2, "I4SWD" },
                    { 3, "I4SWT" },
                    { 4, "I4IKN" },
                    { 5, "I4GUI" }
                });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "AssignmentId", "CourseId", "MaxAssigners", "Name" },
                values: new object[,]
                {
                    { 1, 1, 1, "Modeling" },
                    { 2, 1, 4, "Entity Framework Core" },
                    { 3, 2, 2, "Aflevering 1" },
                    { 4, 4, 3, "Journal 1" }
                });

            migrationBuilder.InsertData(
                table: "Calendars",
                columns: new[] { "EventId", "CourseId", "EventDate", "EventName", "Type" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2019, 04, 08, 10, 15, 00, 715, DateTimeKind.Local).AddTicks(6750), "Lektion 1", "Course lecture" },
                    { 2, 1, new DateTime(2019, 04, 11, 10, 15, 00, 715, DateTimeKind.Local).AddTicks(8318), "Lektion 2", "Course lecture" },
                    { 3, 4, new DateTime(2019, 04, 01, 08, 00, 00, 715, DateTimeKind.Local).AddTicks(8333), "Aflevering 1", "Handin" },
                    { 4, 2, new DateTime(2019, 04, 22, 08, 00, 00, 715, DateTimeKind.Local).AddTicks(8338), "Aflevering 1", "Handin" }
                });



            migrationBuilder.InsertData(
                table: "CourseContents",
                columns: new[] { "CourseContentId", "CourseId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Lektion 1" },
                    { 2, 1, "Lektion 2" },
                    { 3, 5, "MVC" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Birthday", "EnrolledDate", "FirstName", "GraduationDate", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1996,  09,11, 12, 57, 23, 710, DateTimeKind.Local).AddTicks(4753), new DateTime(2017, 08, 27, 12, 57, 23, 713, DateTimeKind.Local).AddTicks(2358), "Thomas", new DateTime(2021, 02, 01, 12, 57, 23, 713, DateTimeKind.Local).AddTicks(2878), "Møller" },
                    { 2, new DateTime(1997, 04, 21, 12, 57, 23, 710, DateTimeKind.Local).AddTicks(4753), new DateTime(2017, 08, 27, 12, 57, 23, 713, DateTimeKind.Local).AddTicks(2358), "Oskar Thorin", new DateTime(2021, 02, 01, 12, 57, 23, 713, DateTimeKind.Local).AddTicks(2878), "Hansen" },
                    { 3, new DateTime(1995, 05, 08, 12, 57, 23, 710, DateTimeKind.Local).AddTicks(4753), new DateTime(2017, 08, 27, 12, 57, 23, 713, DateTimeKind.Local).AddTicks(2358), "Valdemar", new DateTime(2021, 02, 01, 12, 57, 23, 713, DateTimeKind.Local).AddTicks(2878), "Tang" },
                    { 4, new DateTime(1996, 11, 11, 12, 57, 23, 710, DateTimeKind.Local).AddTicks(4753), new DateTime(2017, 08, 27, 12, 57, 23, 713, DateTimeKind.Local).AddTicks(2358), "Mathias Nortvig", new DateTime(2021, 02, 01, 12, 57, 23, 713, DateTimeKind.Local).AddTicks(2878), "Thomassen" },
                    { 9, new DateTime(1993, 09, 21, 12, 57, 23, 710, DateTimeKind.Local).AddTicks(4753), new DateTime(2017, 08, 27, 12, 57, 23, 713, DateTimeKind.Local).AddTicks(2358), "Jonas", new DateTime(2021, 02, 01, 12, 57, 23, 713, DateTimeKind.Local).AddTicks(2878), "Hingebjerg" },
                    { 10, new DateTime(1994, 10, 08, 12, 57, 23, 710, DateTimeKind.Local).AddTicks(4753), new DateTime(2017, 08, 27, 12, 57, 23, 713, DateTimeKind.Local).AddTicks(2358), "Andreas", new DateTime(2021, 02, 01, 12, 57, 23, 713, DateTimeKind.Local).AddTicks(2878), "Harfeld" }
                    
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Birthday", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 5, new DateTime(1980, 01, 01, 12, 57, 23, 713, DateTimeKind.Local).AddTicks(5504), "Lars", "Andersen" },
                    { 6, new DateTime(1978, 12, 02, 12, 57, 23, 713, DateTimeKind.Local).AddTicks(5504), "John", "Michaelsen" },
                    { 7, new DateTime(1982, 08, 04, 12, 57, 23, 713, DateTimeKind.Local).AddTicks(5504), "Fatima", "Fatimasen" },
                    { 8, new DateTime(1973, 06, 15, 12, 57, 23, 713, DateTimeKind.Local).AddTicks(6666), "Jonathan", "Harskov" }
                });

            migrationBuilder.InsertData(
                table: "Assignerses",
                columns: new[] { "AssignersId", "AssignmentId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Thomas Møller" },
                    { 2, 1, "Valdemar Tang" },
                    { 3, 2, "Group 1" },
                    { 4, 2, "Group 2" },
                    { 5, 2, "Group 3" },
                    { 6, 3, "Group 1" },
                    { 7, 3, "Group 2" },
                    { 8, 3, "Group 3" },
                    { 9, 4, "Group 1" },
                    { 10, 4, "Group 2" },
                });

            migrationBuilder.InsertData(
                table: "Attends",
                columns: new[] { "StudentId", "CourseId", "Status" },
                values: new object[,]
                {
                    { 1, 1, "Active" },
                    { 1, 3, "Active" },
                    { 1, 4, "Active" },
                    { 2, 1, "Active" },
                    { 2, 3, "Active" },
                    { 2, 4, "Active" },
                    { 2, 5, "Active" },
                    { 3, 1, "Active" },
                    { 3, 2, "Active" },
                    { 3, 3, "Active" },
                    { 3, 4, "Active" },
                    { 3, 5, "Active" },
                    { 4, 1, "Active" },
                    { 4, 2, "Active" },
                    { 4, 4, "Active" },
                    { 4, 5, "Active" }
                });

            migrationBuilder.InsertData(
                table: "Folders",
                columns: new[] { "FolderId", "CourseContentId", "FolderName" },
                values: new object[,]
                {
                    { 1, 1, "Opgave 1" },
                    { 2, 2, "Lektier" }
                });

            migrationBuilder.InsertData(
                table: "ContentAreas",
                columns: new[] { "ContentAreaId", "CourseContentId", "FolderId", "TextBlock" },
                values: new object[,]
                {
                    { 1, 1, null, "Introduktion til databaser" },
                    { 2, 1, 1, "Opgave 1" },
                    { 3, 1, 1, "Løsning til opgave 1" },
                    { 4, 2, null, "Læs nu jeres lektier forhelvede" }
                });

            migrationBuilder.InsertData(
                table: "Teaches",
                columns: new[] { "AuId", "CourseId", "Role" },
                values: new object[,]
                {
                    { 5, 1, "Teacher" },
                    { 5, 3, "Assistant Teacher" },
                    { 5, 5, "Teacher" },
                    { 6, 1, "Assistant Teacher" },
                    { 6, 2, "Assistant Teacher" },
                    { 6, 4, "Assistant Teacher" },
                    { 7, 3, "Teacher" },
                    { 7, 5, "Assistant Teacher" },
                    { 8, 2, "Teacher" },
                    { 8, 4, "Teacher" }
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
                    { 1, 1, "4", 5, "Det kører" },
                    { 2, 1, "7", 6, "Det er bedre end Thomas'" },
                    { 3, 2, "12", 5, "Blackboard er nu blevet bedre" },
                    { 6, 3, null, null, "Skide god aflevering" },
                    { 9, 4, "10", 8, "Vi vil helst ikke dumpe" }
                });

            migrationBuilder.InsertData(
                table: "StudentAssignerses",
                columns: new[] { "StudentId", "AssignersId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 3, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 3 },
                    { 4, 3 },
                    { 3, 6 },
                    { 4, 6 },
                    { 1, 9 },
                    { 2, 9 },
                    { 3, 9 },
                    { 4, 10 }
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
            //migrationBuilder.DeleteData(
            //    table: "Attends",
            //    keyColumns: new[] { "StudentId", "CourseId" },
            //    keyValues: new object[] { 1, 1 });

            //migrationBuilder.DeleteData(
            //    table: "Attends",
            //    keyColumns: new[] { "StudentId", "CourseId" },
            //    keyValues: new object[] { 1, 2 });

            //migrationBuilder.DeleteData(
            //    table: "Attends",
            //    keyColumns: new[] { "StudentId", "CourseId" },
            //    keyValues: new object[] { 2, 1 });

            //migrationBuilder.DeleteData(
            //    table: "Attends",
            //    keyColumns: new[] { "StudentId", "CourseId" },
            //    keyValues: new object[] { 2, 2 });

            //migrationBuilder.DeleteData(
            //    table: "Calendars",
            //    keyColumn: "EventId",
            //    keyValue: 1);

            //migrationBuilder.DeleteData(
            //    table: "Calendars",
            //    keyColumn: "EventId",
            //    keyValue: 2);

            //migrationBuilder.DeleteData(
            //    table: "Calendars",
            //    keyColumn: "EventId",
            //    keyValue: 3);

            //migrationBuilder.DeleteData(
            //    table: "Calendars",
            //    keyColumn: "EventId",
            //    keyValue: 4);

            //migrationBuilder.DeleteData(
            //    table: "ContentAreas",
            //    keyColumn: "ContentAreaId",
            //    keyValue: 4);

            //migrationBuilder.DeleteData(
            //    table: "ContentLinks",
            //    keyColumn: "ContentLinkId",
            //    keyValue: 1);

            //migrationBuilder.DeleteData(
            //    table: "ContentLinks",
            //    keyColumn: "ContentLinkId",
            //    keyValue: 2);

            //migrationBuilder.DeleteData(
            //    table: "ContentLinks",
            //    keyColumn: "ContentLinkId",
            //    keyValue: 3);

            //migrationBuilder.DeleteData(
            //    table: "ContentLinks",
            //    keyColumn: "ContentLinkId",
            //    keyValue: 4);

            //migrationBuilder.DeleteData(
            //    table: "Folders",
            //    keyColumn: "FolderId",
            //    keyValue: 3);

            //migrationBuilder.DeleteData(
            //    table: "HandIns",
            //    keyColumns: new[] { "AssignersId", "AssignmentId" },
            //    keyValues: new object[] { 1, 1 });

            //migrationBuilder.DeleteData(
            //    table: "HandIns",
            //    keyColumns: new[] { "AssignersId", "AssignmentId" },
            //    keyValues: new object[] { 2, 3 });

            //migrationBuilder.DeleteData(
            //    table: "HandIns",
            //    keyColumns: new[] { "AssignersId", "AssignmentId" },
            //    keyValues: new object[] { 3, 2 });

            //migrationBuilder.DeleteData(
            //    table: "HandIns",
            //    keyColumns: new[] { "AssignersId", "AssignmentId" },
            //    keyValues: new object[] { 4, 1 });

            //migrationBuilder.DeleteData(
            //    table: "HandIns",
            //    keyColumns: new[] { "AssignersId", "AssignmentId" },
            //    keyValues: new object[] { 5, 4 });

            //migrationBuilder.DeleteData(
            //    table: "StudentAssignerses",
            //    keyColumns: new[] { "StudentId", "AssignersId" },
            //    keyValues: new object[] { 1, 1 });

            //migrationBuilder.DeleteData(
            //    table: "StudentAssignerses",
            //    keyColumns: new[] { "StudentId", "AssignersId" },
            //    keyValues: new object[] { 1, 2 });

            //migrationBuilder.DeleteData(
            //    table: "StudentAssignerses",
            //    keyColumns: new[] { "StudentId", "AssignersId" },
            //    keyValues: new object[] { 1, 5 });

            //migrationBuilder.DeleteData(
            //    table: "StudentAssignerses",
            //    keyColumns: new[] { "StudentId", "AssignersId" },
            //    keyValues: new object[] { 2, 1 });

            //migrationBuilder.DeleteData(
            //    table: "StudentAssignerses",
            //    keyColumns: new[] { "StudentId", "AssignersId" },
            //    keyValues: new object[] { 2, 2 });

            //migrationBuilder.DeleteData(
            //    table: "StudentAssignerses",
            //    keyColumns: new[] { "StudentId", "AssignersId" },
            //    keyValues: new object[] { 2, 5 });

            //migrationBuilder.DeleteData(
            //    table: "Teaches",
            //    keyColumns: new[] { "AuId", "CourseId" },
            //    keyValues: new object[] { 3, 1 });

            //migrationBuilder.DeleteData(
            //    table: "Teaches",
            //    keyColumns: new[] { "AuId", "CourseId" },
            //    keyValues: new object[] { 3, 2 });

            //migrationBuilder.DeleteData(
            //    table: "Teaches",
            //    keyColumns: new[] { "AuId", "CourseId" },
            //    keyValues: new object[] { 4, 2 });

            //migrationBuilder.DeleteData(
            //    table: "Teaches",
            //    keyColumns: new[] { "AuId", "CourseId" },
            //    keyValues: new object[] { 4, 3 });

            //migrationBuilder.DeleteData(
            //    table: "Assignerses",
            //    keyColumn: "AssignersId",
            //    keyValue: 1);

            //migrationBuilder.DeleteData(
            //    table: "Assignerses",
            //    keyColumn: "AssignersId",
            //    keyValue: 2);

            //migrationBuilder.DeleteData(
            //    table: "Assignerses",
            //    keyColumn: "AssignersId",
            //    keyValue: 3);

            //migrationBuilder.DeleteData(
            //    table: "Assignerses",
            //    keyColumn: "AssignersId",
            //    keyValue: 4);

            //migrationBuilder.DeleteData(
            //    table: "Assignerses",
            //    keyColumn: "AssignersId",
            //    keyValue: 5);

            //migrationBuilder.DeleteData(
            //    table: "ContentAreas",
            //    keyColumn: "ContentAreaId",
            //    keyValue: 1);

            //migrationBuilder.DeleteData(
            //    table: "ContentAreas",
            //    keyColumn: "ContentAreaId",
            //    keyValue: 2);

            //migrationBuilder.DeleteData(
            //    table: "ContentAreas",
            //    keyColumn: "ContentAreaId",
            //    keyValue: 3);

            //migrationBuilder.DeleteData(
            //    table: "Folders",
            //    keyColumn: "FolderId",
            //    keyValue: 2);

            //migrationBuilder.DeleteData(
            //    table: "Students",
            //    keyColumn: "Id",
            //    keyValue: 1);

            //migrationBuilder.DeleteData(
            //    table: "Students",
            //    keyColumn: "Id",
            //    keyValue: 2);

            //migrationBuilder.DeleteData(
            //    table: "Teachers",
            //    keyColumn: "Id",
            //    keyValue: 3);

            //migrationBuilder.DeleteData(
            //    table: "Teachers",
            //    keyColumn: "Id",
            //    keyValue: 4);

            //migrationBuilder.DeleteData(
            //    table: "Assignments",
            //    keyColumn: "AssignmentId",
            //    keyValue: 1);

            //migrationBuilder.DeleteData(
            //    table: "Assignments",
            //    keyColumn: "AssignmentId",
            //    keyValue: 2);

            //migrationBuilder.DeleteData(
            //    table: "Assignments",
            //    keyColumn: "AssignmentId",
            //    keyValue: 3);

            //migrationBuilder.DeleteData(
            //    table: "Assignments",
            //    keyColumn: "AssignmentId",
            //    keyValue: 4);

            //migrationBuilder.DeleteData(
            //    table: "AuIds",
            //    keyColumn: "Id",
            //    keyValue: 1);

            //migrationBuilder.DeleteData(
            //    table: "AuIds",
            //    keyColumn: "Id",
            //    keyValue: 2);

            //migrationBuilder.DeleteData(
            //    table: "AuIds",
            //    keyColumn: "Id",
            //    keyValue: 3);

            //migrationBuilder.DeleteData(
            //    table: "AuIds",
            //    keyColumn: "Id",
            //    keyValue: 4);

            //migrationBuilder.DeleteData(
            //    table: "CourseContents",
            //    keyColumn: "CourseContentId",
            //    keyValue: 2);

            //migrationBuilder.DeleteData(
            //    table: "CourseContents",
            //    keyColumn: "CourseContentId",
            //    keyValue: 3);

            //migrationBuilder.DeleteData(
            //    table: "Folders",
            //    keyColumn: "FolderId",
            //    keyValue: 1);

            //migrationBuilder.DeleteData(
            //    table: "CourseContents",
            //    keyColumn: "CourseContentId",
            //    keyValue: 1);

            //migrationBuilder.DeleteData(
            //    table: "Courses",
            //    keyColumn: "CourseId",
            //    keyValue: 2);

            //migrationBuilder.DeleteData(
            //    table: "Courses",
            //    keyColumn: "CourseId",
            //    keyValue: 3);

            //migrationBuilder.DeleteData(
            //    table: "Courses",
            //    keyColumn: "CourseId",
            //    keyValue: 1);
        }
    }
}
