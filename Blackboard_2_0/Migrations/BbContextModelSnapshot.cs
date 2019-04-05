﻿// <auto-generated />
using System;
using Blackboard_2_0.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Blackboard_2_0.Migrations
{
    [DbContext(typeof(BbContext))]
    partial class BbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Blackboard_2_0.Models.Data.Assigners", b =>
                {
                    b.Property<int>("AssignersId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("AssignersId");

                    b.ToTable("Assignerses");
                });

            modelBuilder.Entity("Blackboard_2_0.Models.Data.Assignment", b =>
                {
                    b.Property<int>("AssignmentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId");

                    b.Property<int>("MaxAssigners");

                    b.Property<string>("Name");

                    b.HasKey("AssignmentId");

                    b.HasIndex("CourseId");

                    b.ToTable("Assignments");
                });

            modelBuilder.Entity("Blackboard_2_0.Models.Data.Attends", b =>
                {
                    b.Property<int>("StudentId");

                    b.Property<int>("CourseId");

                    b.Property<string>("Status");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("Attends");
                });

            modelBuilder.Entity("Blackboard_2_0.Models.Data.AuId", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Role");

                    b.HasKey("Id");

                    b.ToTable("AuIds");
                });

            modelBuilder.Entity("Blackboard_2_0.Models.Data.Calendar", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId");

                    b.Property<DateTime>("EventDate");

                    b.Property<string>("EventName");

                    b.Property<string>("Type");

                    b.HasKey("EventId");

                    b.HasIndex("CourseId")
                        .IsUnique();

                    b.ToTable("Calendars");
                });

            modelBuilder.Entity("Blackboard_2_0.Models.Data.ContentArea", b =>
                {
                    b.Property<int>("ContentAreaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseContentId");

                    b.Property<int>("FolderId");

                    b.Property<string>("TextBlock");

                    b.HasKey("ContentAreaId");

                    b.HasIndex("CourseContentId");

                    b.HasIndex("FolderId");

                    b.ToTable("ContentAreas");
                });

            modelBuilder.Entity("Blackboard_2_0.Models.Data.ContentLink", b =>
                {
                    b.Property<int>("ContentLinkId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContentAreaId");

                    b.Property<string>("ContentUri");

                    b.Property<string>("Type");

                    b.HasKey("ContentLinkId");

                    b.HasIndex("ContentAreaId");

                    b.ToTable("ContentLinks");
                });

            modelBuilder.Entity("Blackboard_2_0.Models.Data.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Blackboard_2_0.Models.Data.CourseContent", b =>
                {
                    b.Property<int>("CourseContentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId");

                    b.Property<string>("Name");

                    b.HasKey("CourseContentId");

                    b.HasIndex("CourseId");

                    b.ToTable("CourseContents");
                });

            modelBuilder.Entity("Blackboard_2_0.Models.Data.Folder", b =>
                {
                    b.Property<int>("FolderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseContentId");

                    b.Property<string>("FolderName");

                    b.HasKey("FolderId");

                    b.HasIndex("CourseContentId");

                    b.ToTable("Folders");
                });

            modelBuilder.Entity("Blackboard_2_0.Models.Data.HandIn", b =>
                {
                    b.Property<int>("AssignersId");

                    b.Property<int>("AssignmentId");

                    b.Property<string>("Grade");

                    b.Property<int?>("GraderId");

                    b.Property<string>("Text");

                    b.HasKey("AssignersId", "AssignmentId");

                    b.HasIndex("AssignmentId");

                    b.HasIndex("GraderId");

                    b.ToTable("HandIns");
                });

            modelBuilder.Entity("Blackboard_2_0.Models.Data.Student", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Blackboard_2_0.Models.Data.StudentAssigners", b =>
                {
                    b.Property<int>("StudentId");

                    b.Property<int>("AssignersId");

                    b.HasKey("StudentId", "AssignersId");

                    b.HasIndex("AssignersId");

                    b.ToTable("StudentAssignerses");
                });

            modelBuilder.Entity("Blackboard_2_0.Models.Data.Teacher", b =>
                {
                    b.Property<int>("Id");

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Blackboard_2_0.Models.Data.Teaches", b =>
                {
                    b.Property<int>("AuId");

                    b.Property<int>("CourseId");

                    b.Property<string>("Role");

                    b.HasKey("AuId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("Teaches");
                });

            modelBuilder.Entity("Blackboard_2_0.Models.Data.Assignment", b =>
                {
                    b.HasOne("Blackboard_2_0.Models.Data.Course", "Course")
                        .WithMany("Assignments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Blackboard_2_0.Models.Data.Attends", b =>
                {
                    b.HasOne("Blackboard_2_0.Models.Data.Course", "Course")
                        .WithMany("Students")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Blackboard_2_0.Models.Data.Student", "Student")
                        .WithMany("Attends")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Blackboard_2_0.Models.Data.Calendar", b =>
                {
                    b.HasOne("Blackboard_2_0.Models.Data.Course", "Course")
                        .WithOne("Calendar")
                        .HasForeignKey("Blackboard_2_0.Models.Data.Calendar", "CourseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Blackboard_2_0.Models.Data.ContentArea", b =>
                {
                    b.HasOne("Blackboard_2_0.Models.Data.CourseContent", "CourseContent")
                        .WithMany("ContentAreas")
                        .HasForeignKey("CourseContentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Blackboard_2_0.Models.Data.Folder", "Folder")
                        .WithMany("ContentAreas")
                        .HasForeignKey("FolderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Blackboard_2_0.Models.Data.ContentLink", b =>
                {
                    b.HasOne("Blackboard_2_0.Models.Data.ContentArea", "ContentArea")
                        .WithMany("ContentLinks")
                        .HasForeignKey("ContentAreaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Blackboard_2_0.Models.Data.CourseContent", b =>
                {
                    b.HasOne("Blackboard_2_0.Models.Data.Course", "Course")
                        .WithMany("CourseContents")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Blackboard_2_0.Models.Data.Folder", b =>
                {
                    b.HasOne("Blackboard_2_0.Models.Data.CourseContent", "CourseContent")
                        .WithMany("Folders")
                        .HasForeignKey("CourseContentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Blackboard_2_0.Models.Data.HandIn", b =>
                {
                    b.HasOne("Blackboard_2_0.Models.Data.Assigners", "Assigners")
                        .WithMany("HandIns")
                        .HasForeignKey("AssignersId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Blackboard_2_0.Models.Data.Assignment", "Assignment")
                        .WithMany("HandIns")
                        .HasForeignKey("AssignmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Blackboard_2_0.Models.Data.Teacher", "Grader")
                        .WithMany("HandIns")
                        .HasForeignKey("GraderId");
                });

            modelBuilder.Entity("Blackboard_2_0.Models.Data.Student", b =>
                {
                    b.HasOne("Blackboard_2_0.Models.Data.AuId", "AuId")
                        .WithOne("Student")
                        .HasForeignKey("Blackboard_2_0.Models.Data.Student", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Blackboard_2_0.Models.Data.StudentAssigners", b =>
                {
                    b.HasOne("Blackboard_2_0.Models.Data.Assigners", "Assigners")
                        .WithMany("Students")
                        .HasForeignKey("AssignersId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Blackboard_2_0.Models.Data.Student", "Student")
                        .WithMany("Assigners")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Blackboard_2_0.Models.Data.Teacher", b =>
                {
                    b.HasOne("Blackboard_2_0.Models.Data.AuId", "AuId")
                        .WithOne("Teacher")
                        .HasForeignKey("Blackboard_2_0.Models.Data.Teacher", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Blackboard_2_0.Models.Data.Teaches", b =>
                {
                    b.HasOne("Blackboard_2_0.Models.Data.Teacher", "Teacher")
                        .WithMany("Teaches")
                        .HasForeignKey("AuId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Blackboard_2_0.Models.Data.Course", "Course")
                        .WithMany("Teachers")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
