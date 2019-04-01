using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Blackboard_2_0.Models.Data
{
    public class BBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teaches> Teaches { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Attends> Attends { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
