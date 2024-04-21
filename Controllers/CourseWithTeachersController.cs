using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoxSchool.Data;
using RoxSchool.Models;

namespace RoxSchool.Controllers
{
    public class CourseWithTeachersController : Controller
    {
        private readonly AppDbContext _context;
        string SelectedCourse = null;

        public CourseWithTeachersController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int? courseId)
        {
            var courses = await _context.Courses.ToListAsync();

            var query = from course in _context.Courses
                        join teach in _context.Teachers on course.FkTeacherId equals teach.TeacherId
                        select new { course, teach };

            if (courseId.HasValue)
            {
                query = query.Where(x => x.course.CourseId == courseId.Value);
            }

            var teachers = await query.Select(x => new CourseWithTeacher
            {
                TeacherName = x.teach.TeacherName,
                TeacherEmail = x.teach.TeacherEmail,
                TeacherPhone = x.teach.TeacherPhone

            }).ToListAsync();

            if (courseId.HasValue)
            {
                var selectedCourse = await _context.Courses.Where(x => x.CourseId == courseId.Value).FirstOrDefaultAsync();
                if (selectedCourse != null)
                {
                    SelectedCourse = selectedCourse.CourseName;
                }
            }


            var viewModel = new CourseWithTeacherViewModel()
            {
                Teachers = teachers,
                Courses = courses,
                SelectedCourse = SelectedCourse

            };

            return View(viewModel);
        }
    }
}
