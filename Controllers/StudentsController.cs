using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [Route("/api/students")]
    public class StudentsController : Controller
    {
        //private static List<Student> _students;
        public StudentsController(IStudentsRepository student)
        {
            Student = student;
            /*if (_students == null)
            {
                _students = new List<Student>
                {
                    new Student
                    {
                        SSN  = 0104932859,
                        Name = "Holmfridur"
                    },
                    new Student
                    {
                        SSN  = 0293265523,
                        Name = "Steinn"
                    },
                    new Student
                    {
                        SSN  = 0655231129,
                        Name = "Tomas"
                    },
                };
            }*/
        }
        public IStudentsRepository Student { get; set; }
        public IEnumerable<Student> GetAllStudents()
        {
            return Student.GetAllStudents();
        }

        public ActionResult Index()
        {
           Console.WriteLine("got here.");
           return View();
        }
    }
}