using ASPLabb2.Data;
using ASPLabb2.Migrations;
using ASPLabb2.Models;
using ASPLabb2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ASPLabb2.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;
        public HomeController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Task1()
        {
            int teacherId = _context.Courses
                .Where(c => c.Id == 1)
                .Select(c => c.TeacherId)
                .FirstOrDefault();

            var teachers = _context.Teachers
                .Where(teacher => teacher.Id == teacherId).ToList();

            return View(teachers);            
        }

        public IActionResult Task2()
        {
            var studentTeachers = _context.Students
                .Select(student => new StudentTeachers
                {
                    Student = student,
                    Teachers = _context.StudentCourses
                        .Where(sc => sc.StudentId == student.Id)
                        .Select(sc => sc.Course.Teacher).ToList()
                })
                .ToList();

            return View(studentTeachers);
        }

        public IActionResult Task3()
        {
            var studentTeachers = _context.StudentCourses
                .Where(sc => sc.CourseId == 1)
                .Select(sc => sc.Student)
                .Select(student => new StudentTeachers
                {
                    Student = student,
                    Teachers = _context.StudentCourses
                        .Where(sc => sc.CourseId == 1)
                        .Select(sc => sc.Course.Teacher).ToList()
                })
                .ToList();


            return View(studentTeachers);
        }

        public IActionResult Task4()
        {
            var courseToEdit = _context.Courses
                .FirstOrDefault(c => c.Id == 3);

            if(courseToEdit.CourseName != "OOP")
            {
                courseToEdit.CourseName = "OOP";
            }
            else
            {
                courseToEdit.CourseName = "Programmering 2";
            }
            
            _context.SaveChanges();

            return View();
        }

        public IActionResult Task5()
        {
            var courseToEdit = _context.Courses
                .FirstOrDefault(c => c.Id == 1);

            if(courseToEdit.TeacherId != 5)
            {
                courseToEdit.TeacherId = 5;
            }
            else
            {
                courseToEdit.TeacherId = 4;
            }
            
            _context.SaveChanges();
            return View();
        }



    }
}