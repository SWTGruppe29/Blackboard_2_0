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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attends>()
                .HasKey(x => new { x.StudentId, x.CourseId });
            
        }
    }
}
