using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoxSchool.Data;
using RoxSchool.Models;

namespace RoxSchool.Controllers
{
    public class StudentWithTeachersController : Controller
    {
        private readonly AppDbContext _context;

        public StudentWithTeachersController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            //var query = from enroll in _context.Enrollments
            //            join stu in _context.Students on enroll.FkStudentId equals stu.StudentId
            //            join cours in _context.Courses on enroll.FkCourseId equals cours.CourseId
            //            join teach in _context.Teachers on cours.FkTeacherId equals teach.TeacherId
            //            group new { teach.TeacherName, cours.CourseName } by stu.StudentName into studentGroup
            //            select new StudentWithTeachers
            //            {
            //                StudentName = studentGroup.Key,
            //                Teachers = studentGroup.Select(x => new TeacherWithCourse
            //                {
            //                    TeacherName = x.TeacherName,
            //                    CourseName = x.CourseName
            //                }).ToList()
            //            };

            var query = from enroll in _context.Enrollments 
                        join stu in _context.Students on enroll.FkStudentId equals stu.StudentId
                        join cours in _context.Courses on enroll.FkCourseId equals cours.CourseId
                        join teach in _context.Teachers on cours.FkTeacherId equals teach.TeacherId
                        group teach.TeacherName by stu.StudentName into studentGroup
                        select new StudentWithTeachers{ StudentName = studentGroup.Key, TeacherNames = studentGroup.ToList() };

            var studentTeachers = await query.ToListAsync();
            return View(studentTeachers);
        }

    }
}
