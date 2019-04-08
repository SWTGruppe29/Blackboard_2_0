using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Blackboard_2_0.Models.Data
{
    public class BbContext : DbContext
    {
        public BbContext(DbContextOptions<BbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teaches> Teaches { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Attends> Attends { get; set; }

        public DbSet<ContentArea> ContentAreas { get; set; }
        public DbSet<CourseContent> CourseContents { get; set; }
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<Assigners> Assignerses { get; set; }
        public DbSet<AuId> AuIds { get; set; }
        public DbSet<ContentLink> ContentLinks { get; set; }
        public DbSet<Folder> Folders { get; set; }
        public DbSet<HandIn> HandIns { get; set; }
        public DbSet<StudentAssigners> StudentAssignerses { get; set; }
     

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attends>()
                .HasKey(x => new { x.StudentId, x.CourseId });

            modelBuilder.Entity<Attends>()
                .HasOne(a => a.Student)
                .WithMany(s => s.Attends)
                .HasForeignKey(a => a.StudentId);
            modelBuilder.Entity<Attends>()
                .HasOne(a => a.Course)
                .WithMany(c => c.Students)
                .HasForeignKey(a => a.CourseId);

            modelBuilder.Entity<Teaches>()
                .HasKey(x => new {x.AuId, x.CourseId});

            modelBuilder.Entity<Teaches>()
                .HasOne(t => t.Course)
                .WithMany(c => c.Teachers)
                .HasForeignKey(t => t.CourseId);
            modelBuilder.Entity<Teaches>()
                .HasOne(t => t.Teacher)
                .WithMany(t => t.Teaches)
                .HasForeignKey(t => t.AuId);


            modelBuilder.Entity<StudentAssigners>()
                .HasKey(x => new {x.StudentId, x.AssignersId});

            modelBuilder.Entity<StudentAssigners>()
                .HasOne(sa => sa.Student)
                .WithMany(s => s.Assigners)
                .HasForeignKey(sa => sa.StudentId);
            modelBuilder.Entity<StudentAssigners>()
                .HasOne(sa => sa.Assigners)
                .WithMany(a => a.Students)
                .HasForeignKey(sa => sa.AssignersId);

            modelBuilder.Entity<HandIn>()
                .HasKey(x => new {x.AssignersId, x.AssignmentId});
            modelBuilder.Entity<HandIn>()
                .Property(x => x.GraderId).IsRequired(false);


            modelBuilder.Entity<ContentArea>()
                .HasKey(x => x.ContentAreaId);

            modelBuilder.Entity<ContentArea>()
                .HasOne(b => b.CourseContent)
                .WithMany(a => a.ContentAreas)
                .HasForeignKey(b => b.CourseContentId);

            modelBuilder.Entity<ContentArea>()
                .HasOne(b => b.Folder)
                .WithMany(a => a.ContentAreas)
                .HasForeignKey(b => b.FolderId)
                .IsRequired(false);


            modelBuilder.Entity<Calendar>()
                .HasIndex(e => e.CourseId)
                .IsUnique(false);


            modelBuilder.Entity<Assigners>()
                .HasOne(a => a.Assignment)
                .WithMany(b => b.Assigners)
                .HasForeignKey(a => a.AssignmentId);



            Seed(modelBuilder);
        }


        private void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    AuId = new AuId(),

                });

            modelBuilder.Entity<AuId>().HasData(
                new AuId()
                {
                    Id = 1,
                    Role = "Student",
                },
                new AuId()
                {
                    Id = 2,
                    Role = "Student"
                },
                new AuId()
                {
                    Id = 3,
                    Role = "Teacher"
                },
                new AuId()
                {
                    Id = 4,
                    Role = "Teacher"
                }
                );

            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    Id = 1,
                    Birthday = DateTime.Now,
                    EnrolledDate = DateTime.Now - TimeSpan.FromDays(10),
                    GraduationDate = DateTime.Now + TimeSpan.FromDays(350),
                    FirstName = "Thomas",
                    LastName = "Moeller"
                },
                new Student()
                {
                    Id = 2,
                    Birthday = DateTime.Now - TimeSpan.FromDays(1000),
                    EnrolledDate = DateTime.Now - TimeSpan.FromDays(100),
                    GraduationDate = DateTime.Now + TimeSpan.FromDays(250),
                    FirstName = "Oskar",
                    LastName = "Hansen"
                }
            );
            modelBuilder.Entity<Teacher>().HasData(
                new Teacher()
                {
                    Id = 3,
                    Birthday = DateTime.Now - TimeSpan.FromDays(500),
                    FirstName = "Mathias",
                    LastName = "Thomassen"
                },
                new Teacher()
                {
                    Id = 4,
                    Birthday = DateTime.Now - TimeSpan.FromDays(1000),
                    FirstName = "Valdemar",
                    LastName = "Tang"
                }
            );

            modelBuilder.Entity<Course>().HasData(
                new Course()
                {
                    CourseId = 1,
                    Name = "I4DAB",

                },
                new Course()
                {
                    CourseId = 2,
                    Name = "I4GUI"
                },
                new Course()
                {
                    CourseId = 3,
                    Name = "I4SWD"
                }
            );

            modelBuilder.Entity<Teaches>().HasData(
                new Teaches()
                {
                    AuId = 3,
                    CourseId = 1,
                    Role = "Teacher",
                },
                new Teaches()
                {
                    AuId = 4,
                    CourseId = 2,
                    Role = "Teacher"
                },
                new Teaches()
                {
                    AuId = 3,
                    CourseId = 2,
                    Role = "Assistant Teacher"
                },
                new Teaches()
                {
                    AuId = 4,
                    CourseId = 3,
                    Role = "Teacher"
                }
            );

            modelBuilder.Entity<Attends>().HasData(
                new Attends()
                {
                    StudentId = 1,
                    CourseId = 1,
                    Status = "Active",
                },
                new Attends()
                {
                    StudentId = 2,
                    CourseId = 2,
                    Status = "Active"
                },
                new Attends()
                {
                    StudentId = 1,
                    CourseId = 2,
                    Status = "Failed"
                },
                new Attends()
                {
                    StudentId = 2,
                    CourseId = 1,
                    Status = "Passed"
                }
            );

            modelBuilder.Entity<CourseContent>().HasData(
                new CourseContent()
                {
                    CourseId = 1,
                    CourseContentId = 1,
                    Name = "EF Core"
                },
                new CourseContent()
                {
                    CourseId = 2,
                    CourseContentId = 2,
                    Name = "MVC"
                },
                new CourseContent()
                {
                    CourseId = 1,
                    CourseContentId = 3,
                    Name = "SQL"
                }
            );


            modelBuilder.Entity<Folder>().HasData(
                new Folder()
                {
                    CourseContentId = 1,
                    FolderId = 1,
                    FolderName = "Examples"
                },
                new Folder()
                {
                    CourseContentId = 1,
                    FolderId = 2,
                    FolderName = "Slides"
                },
                new Folder()
                {
                    CourseContentId = 2,
                    FolderId = 3,
                    FolderName = "Presentation"
                }
            );

            modelBuilder.Entity<ContentArea>().HasData(
                new ContentArea()
                {
                    ContentAreaId = 1,
                    CourseContentId = 1,
                    TextBlock = "Migrationzzzzz..........",

                },
                new ContentArea()
                {
                    ContentAreaId = 2,
                    CourseContentId = 3,
                    TextBlock = "Insert, delete update....",
                    FolderId = 1
                },
                new ContentArea()
                {
                    ContentAreaId = 3,
                    CourseContentId = 2,
                    TextBlock = "Kig her!",
                },
                new ContentArea()
                {
                    ContentAreaId = 4,
                    CourseContentId = 1,
                    TextBlock = "Kan snart ikke finde på mere",
                    FolderId = 2
                }
            );

            modelBuilder.Entity<ContentLink>().HasData(
                new ContentLink()
                {
                    ContentAreaId = 1,
                    ContentLinkId = 1,
                    ContentUri = "https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/",
                    Type = "WebPage"
                },
                new ContentLink()
                {
                    ContentAreaId = 2,
                    ContentLinkId = 2,
                    ContentUri = "https://www.youtube.com/watch?v=dQw4w9WgXcQ"
                },
                new ContentLink()
                {
                    ContentAreaId = 3,
                    ContentLinkId = 3,
                    ContentUri = "https://www.youtube.com/watch?v=tEId2k4wu6w"
                },
                new ContentLink()
                {
                    ContentAreaId = 2,
                    ContentLinkId = 4,
                    ContentUri = "https://www.youtube.com/watch?v=DtJgNvwmsRA"
                }
            );

            modelBuilder.Entity<Assignment>().HasData(
                new Assignment()
                {
                    AssignmentId = 1,
                    CourseId = 1,
                    MaxAssigners = 4,
                    Name = "EF Core Assignment"
                },
                new Assignment()
                {
                    AssignmentId = 2,
                    CourseId = 1,
                    MaxAssigners = 1,
                    Name = "SQL Server BB2"
                },
                new Assignment()
                {
                    AssignmentId = 3,
                    CourseId = 2,
                    MaxAssigners = 1,
                    Name = "JavaJam"
                },
                new Assignment()
                {
                    AssignmentId = 4,
                    CourseId = 3,
                    MaxAssigners = 3,
                    Name = "GUI Assignment"
                }
            );

            modelBuilder.Entity<Assigners>().HasData(
                new Assigners()
                {
                    AssignersId = 1,
                    AssignmentId = 1,
                    Name = "Gruppe 12!"
                },
                new Assigners()
                {
                    AssignersId = 2,
                    AssignmentId = 3,
                    Name = "Gruppe 11"
                },
                new Assigners()
                {
                    AssignersId = 3,
                    AssignmentId = 2,
                    Name = "Gruppe 1"
                },
                new Assigners()
                {
                    AssignersId = 4,
                    AssignmentId = 1,
                    Name = "Gruppe 15!"
                },
                new Assigners()
                {
                    AssignersId = 5,
                    AssignmentId = 4,
                    Name = "Gruppe 22"
                }
            );

            modelBuilder.Entity<StudentAssigners>().HasData(
                new StudentAssigners()
                {
                    AssignersId = 1,
                    StudentId = 1,
                },
                new StudentAssigners()
                {
                    AssignersId = 1,
                    StudentId = 2
                },
                new StudentAssigners()
                {
                    AssignersId = 2,
                    StudentId = 1
                },
                new StudentAssigners()
                {
                    AssignersId = 2,
                    StudentId = 2
                },
                new StudentAssigners()
                {
                    AssignersId = 5,
                    StudentId = 2
                },
                new StudentAssigners()
                {
                    AssignersId = 5,
                    StudentId = 1
                }
            );

            modelBuilder.Entity<HandIn>().HasData(
                new HandIn()
                {
                    AssignersId = 1,
                    AssignmentId = 1,
                    Grade = "12",
                    Text = "Dette er handin 1 for gruppe 12",
                    GraderId = 1
                },
                new HandIn()
                {
                    AssignersId = 2,
                    AssignmentId = 3,
                    Grade = "-3",
                    Text = "Handin for gruppe 11",
                    GraderId = 2
                },
                new HandIn()
                {
                    AssignersId = 3,
                    AssignmentId = 2,
                    Grade = "4",
                    Text = "Øvv",
                    GraderId = 1
                },
                new HandIn()
                {
                    AssignersId = 4,
                    AssignmentId = 1,
                    GraderId = 2,
                    Grade = "02",
                    Text = "Meh"
                },
                new HandIn()
                {
                    AssignersId = 5,
                    AssignmentId = 4,
                    Grade = "10",
                    GraderId = 2,
                    Text = "Godt forsøg"
                }
            );


            modelBuilder.Entity<Calendar>().HasData(
                new Calendar()
                {
                    CourseId = 1,
                    EventDate = DateTime.Now + TimeSpan.FromDays(10),
                    EventId = 1,
                    EventName = "Aflevering",
                    Type = "Deadline"
                },
                new Calendar()
                {
                    CourseId = 2,
                    EventName = "Undervisning",
                    EventDate = DateTime.Now + TimeSpan.FromHours(100),
                    EventId = 2,
                    Type = "Lecture"
                },
                new Calendar()
                {
                    CourseId = 2,
                    EventName = "Opgaver",
                    EventDate = DateTime.Now + TimeSpan.FromDays(20),
                    EventId = 3,
                    Type = "Group work"
                },
                new Calendar()
                {
                    CourseId = 3,
                    EventName = "Forelæsning",
                    EventDate = DateTime.Now + TimeSpan.FromDays(2),
                    EventId = 4,
                    Type = "Lecture"
                }
            );
            
            
        }
    }
}
