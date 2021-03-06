﻿// <auto-generated />
using System;
using Blackboard_2_0.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Blackboard_2_0.Migrations
{
    [DbContext(typeof(BbContext))]
    [Migration("20190408114434_ChangedCalendarName")]
    partial class ChangedCalendarName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("AssignmentId");

                    b.Property<string>("Name");

                    b.HasKey("AssignersId");

                    b.HasIndex("AssignmentId");

                    b.ToTable("Assignerses");

                    b.HasData(
                        new
                        {
                            AssignersId = 1,
                            AssignmentId = 1,
                            Name = "Gruppe 12!"
                        },
                        new
                        {
                            AssignersId = 2,
                            AssignmentId = 3,
                            Name = "Gruppe 11"
                        },
                        new
                        {
                            AssignersId = 3,
                            AssignmentId = 2,
                            Name = "Gruppe 1"
                        },
                        new
                        {
                            AssignersId = 4,
                            AssignmentId = 1,
                            Name = "Gruppe 15!"
                        },
                        new
                        {
                            AssignersId = 5,
                            AssignmentId = 4,
                            Name = "Gruppe 22"
                        });
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

                    b.HasData(
                        new
                        {
                            AssignmentId = 1,
                            CourseId = 1,
                            MaxAssigners = 4,
                            Name = "EF Core Assignment"
                        },
                        new
                        {
                            AssignmentId = 2,
                            CourseId = 1,
                            MaxAssigners = 1,
                            Name = "SQL Server BB2"
                        },
                        new
                        {
                            AssignmentId = 3,
                            CourseId = 2,
                            MaxAssigners = 1,
                            Name = "JavaJam"
                        },
                        new
                        {
                            AssignmentId = 4,
                            CourseId = 3,
                            MaxAssigners = 3,
                            Name = "GUI Assignment"
                        });
                });

            modelBuilder.Entity("Blackboard_2_0.Models.Data.Attends", b =>
                {
                    b.Property<int>("StudentId");

                    b.Property<int>("CourseId");

                    b.Property<string>("Status");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("Attends");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            CourseId = 1,
                            Status = "Active"
                        },
                        new
                        {
                            StudentId = 2,
                            CourseId = 2,
                            Status = "Active"
                        },
                        new
                        {
                            StudentId = 1,
                            CourseId = 2,
                            Status = "Failed"
                        },
                        new
                        {
                            StudentId = 2,
                            CourseId = 1,
                            Status = "Passed"
                        });
                });

            modelBuilder.Entity("Blackboard_2_0.Models.Data.AuId", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Role");

                    b.HasKey("Id");

                    b.ToTable("AuIds");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Role = "Student"
                        },
                        new
                        {
                            Id = 2,
                            Role = "Student"
                        },
                        new
                        {
                            Id = 3,
                            Role = "Teacher"
                        },
                        new
                        {
                            Id = 4,
                            Role = "Teacher"
                        });
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

                    b.HasIndex("CourseId");

                    b.ToTable("Calendars");

                    b.HasData(
                        new
                        {
                            EventId = 1,
                            CourseId = 1,
                            EventDate = new DateTime(2019, 4, 18, 13, 44, 32, 806, DateTimeKind.Local).AddTicks(8249),
                            EventName = "Aflevering",
                            Type = "Deadline"
                        },
                        new
                        {
                            EventId = 2,
                            CourseId = 2,
                            EventDate = new DateTime(2019, 4, 12, 17, 44, 32, 812, DateTimeKind.Local).AddTicks(8272),
                            EventName = "Undervisning",
                            Type = "Lecture"
                        },
                        new
                        {
                            EventId = 3,
                            CourseId = 2,
                            EventDate = new DateTime(2019, 4, 28, 13, 44, 32, 812, DateTimeKind.Local).AddTicks(8340),
                            EventName = "Opgaver",
                            Type = "Group work"
                        },
                        new
                        {
                            EventId = 4,
                            CourseId = 3,
                            EventDate = new DateTime(2019, 4, 10, 13, 44, 32, 812, DateTimeKind.Local).AddTicks(8348),
                            EventName = "Forelæsning",
                            Type = "Lecture"
                        });
                });

            modelBuilder.Entity("Blackboard_2_0.Models.Data.ContentArea", b =>
                {
                    b.Property<int>("ContentAreaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseContentId");

                    b.Property<int?>("FolderId");

                    b.Property<string>("TextBlock");

                    b.HasKey("ContentAreaId");

                    b.HasIndex("CourseContentId");

                    b.HasIndex("FolderId");

                    b.ToTable("ContentAreas");

                    b.HasData(
                        new
                        {
                            ContentAreaId = 1,
                            CourseContentId = 1,
                            TextBlock = "Migrationzzzzz.........."
                        },
                        new
                        {
                            ContentAreaId = 2,
                            CourseContentId = 3,
                            FolderId = 1,
                            TextBlock = "Insert, delete update...."
                        },
                        new
                        {
                            ContentAreaId = 3,
                            CourseContentId = 2,
                            TextBlock = "Kig her!"
                        },
                        new
                        {
                            ContentAreaId = 4,
                            CourseContentId = 1,
                            FolderId = 2,
                            TextBlock = "Kan snart ikke finde på mere"
                        });
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

                    b.HasData(
                        new
                        {
                            ContentLinkId = 1,
                            ContentAreaId = 1,
                            ContentUri = "https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/",
                            Type = "WebPage"
                        },
                        new
                        {
                            ContentLinkId = 2,
                            ContentAreaId = 2,
                            ContentUri = "https://www.youtube.com/watch?v=dQw4w9WgXcQ"
                        },
                        new
                        {
                            ContentLinkId = 3,
                            ContentAreaId = 3,
                            ContentUri = "https://www.youtube.com/watch?v=tEId2k4wu6w"
                        },
                        new
                        {
                            ContentLinkId = 4,
                            ContentAreaId = 2,
                            ContentUri = "https://www.youtube.com/watch?v=DtJgNvwmsRA"
                        });
                });

            modelBuilder.Entity("Blackboard_2_0.Models.Data.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            Name = "I4DAB"
                        },
                        new
                        {
                            CourseId = 2,
                            Name = "I4GUI"
                        },
                        new
                        {
                            CourseId = 3,
                            Name = "I4SWD"
                        });
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

                    b.HasData(
                        new
                        {
                            CourseContentId = 1,
                            CourseId = 1,
                            Name = "EF Core"
                        },
                        new
                        {
                            CourseContentId = 2,
                            CourseId = 2,
                            Name = "MVC"
                        },
                        new
                        {
                            CourseContentId = 3,
                            CourseId = 1,
                            Name = "SQL"
                        });
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

                    b.HasData(
                        new
                        {
                            FolderId = 1,
                            CourseContentId = 1,
                            FolderName = "Examples"
                        },
                        new
                        {
                            FolderId = 2,
                            CourseContentId = 1,
                            FolderName = "Slides"
                        },
                        new
                        {
                            FolderId = 3,
                            CourseContentId = 2,
                            FolderName = "Presentation"
                        });
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

                    b.HasData(
                        new
                        {
                            AssignersId = 1,
                            AssignmentId = 1,
                            Grade = "12",
                            GraderId = 1,
                            Text = "Dette er handin 1 for gruppe 12"
                        },
                        new
                        {
                            AssignersId = 2,
                            AssignmentId = 3,
                            Grade = "-3",
                            GraderId = 2,
                            Text = "Handin for gruppe 11"
                        },
                        new
                        {
                            AssignersId = 3,
                            AssignmentId = 2,
                            Grade = "4",
                            GraderId = 1,
                            Text = "Øvv"
                        },
                        new
                        {
                            AssignersId = 4,
                            AssignmentId = 1,
                            Grade = "02",
                            GraderId = 2,
                            Text = "Meh"
                        },
                        new
                        {
                            AssignersId = 5,
                            AssignmentId = 4,
                            Grade = "10",
                            GraderId = 2,
                            Text = "Godt forsøg"
                        });
                });

            modelBuilder.Entity("Blackboard_2_0.Models.Data.Student", b =>
                {
                    b.Property<int>("Id");

                    b.Property<DateTime>("Birthday");

                    b.Property<DateTime>("EnrolledDate");

                    b.Property<string>("FirstName");

                    b.Property<DateTime>("GraduationDate");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Birthday = new DateTime(2019, 4, 8, 13, 44, 32, 796, DateTimeKind.Local).AddTicks(9741),
                            EnrolledDate = new DateTime(2019, 3, 29, 13, 44, 32, 800, DateTimeKind.Local).AddTicks(2222),
                            FirstName = "Thomas",
                            GraduationDate = new DateTime(2020, 3, 23, 13, 44, 32, 800, DateTimeKind.Local).AddTicks(3224),
                            LastName = "Moeller"
                        },
                        new
                        {
                            Id = 2,
                            Birthday = new DateTime(2016, 7, 12, 13, 44, 32, 800, DateTimeKind.Local).AddTicks(5728),
                            EnrolledDate = new DateTime(2018, 12, 29, 13, 44, 32, 800, DateTimeKind.Local).AddTicks(5756),
                            FirstName = "Oskar",
                            GraduationDate = new DateTime(2019, 12, 14, 13, 44, 32, 800, DateTimeKind.Local).AddTicks(5767),
                            LastName = "Hansen"
                        });
                });

            modelBuilder.Entity("Blackboard_2_0.Models.Data.StudentAssigners", b =>
                {
                    b.Property<int>("StudentId");

                    b.Property<int>("AssignersId");

                    b.HasKey("StudentId", "AssignersId");

                    b.HasIndex("AssignersId");

                    b.ToTable("StudentAssignerses");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            AssignersId = 1
                        },
                        new
                        {
                            StudentId = 2,
                            AssignersId = 1
                        },
                        new
                        {
                            StudentId = 1,
                            AssignersId = 2
                        },
                        new
                        {
                            StudentId = 2,
                            AssignersId = 2
                        },
                        new
                        {
                            StudentId = 2,
                            AssignersId = 5
                        },
                        new
                        {
                            StudentId = 1,
                            AssignersId = 5
                        });
                });

            modelBuilder.Entity("Blackboard_2_0.Models.Data.Teacher", b =>
                {
                    b.Property<int>("Id");

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            Birthday = new DateTime(2017, 11, 24, 13, 44, 32, 800, DateTimeKind.Local).AddTicks(8856),
                            FirstName = "Mathias",
                            LastName = "Thomassen"
                        },
                        new
                        {
                            Id = 4,
                            Birthday = new DateTime(2016, 7, 12, 13, 44, 32, 801, DateTimeKind.Local).AddTicks(1933),
                            FirstName = "Valdemar",
                            LastName = "Tang"
                        });
                });

            modelBuilder.Entity("Blackboard_2_0.Models.Data.Teaches", b =>
                {
                    b.Property<int>("AuId");

                    b.Property<int>("CourseId");

                    b.Property<string>("Role");

                    b.HasKey("AuId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("Teaches");

                    b.HasData(
                        new
                        {
                            AuId = 3,
                            CourseId = 1,
                            Role = "Teacher"
                        },
                        new
                        {
                            AuId = 4,
                            CourseId = 2,
                            Role = "Teacher"
                        },
                        new
                        {
                            AuId = 3,
                            CourseId = 2,
                            Role = "Assistant Teacher"
                        },
                        new
                        {
                            AuId = 4,
                            CourseId = 3,
                            Role = "Teacher"
                        });
                });

            modelBuilder.Entity("Blackboard_2_0.Models.Data.Assigners", b =>
                {
                    b.HasOne("Blackboard_2_0.Models.Data.Assignment", "Assignment")
                        .WithMany("Assigners")
                        .HasForeignKey("AssignmentId")
                        .OnDelete(DeleteBehavior.Cascade);
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
                        .WithMany("Events")
                        .HasForeignKey("CourseId")
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
                        .HasForeignKey("FolderId");
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
