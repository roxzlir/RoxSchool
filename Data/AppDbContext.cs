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
        DbSet<Student> Students { get; set; }
        DbSet<Teacher> Teachers { get; set; }
        DbSet<Course> Courses { get; set; }
        DbSet<StudentClass> StudentClasses { get; set; }
        DbSet<Enrollment> Enrollments { get; set; }

    }
}
