using Microsoft.EntityFrameworkCore;
using RoxSchool.Models;

namespace RoxSchool.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentClass> StudentClasses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

    }
}
