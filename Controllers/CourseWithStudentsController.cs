using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoxSchool.Data;
using RoxSchool.Models;

namespace RoxSchool.Controllers
{
    public class CourseWithStudentsController : Controller
    {
        private readonly AppDbContext _context;

        public CourseWithStudentsController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var query = from enroll in _context.Enrollments
                        join stu in _context.Students on enroll.FkStudentId equals stu.StudentId
                        join cours in _context.Courses on enroll.FkCourseId equals cours.CourseId
                        join teach in _context.Teachers on cours.FkTeacherId equals teach.TeacherId
                        group new { stu.StudentName, teach.TeacherName } by new { cours.CourseName, teach.TeacherName } into courseGroup
                        select new CourseWithStudents
                        {
                            CourseName = courseGroup.Key.CourseName,
                            StudentNames = courseGroup.Select(x => x.StudentName).ToList(),
                            TeacherName = courseGroup.Key.TeacherName
                        };

            var coursesWithStudents = await query.ToListAsync();
            return View(coursesWithStudents);
        }
    }
}
