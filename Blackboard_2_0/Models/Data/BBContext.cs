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
                .HasForeignKey(b => b.ContentAreaId);



        }
    }
}
