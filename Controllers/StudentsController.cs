using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication.Models;
using WebApplication.Models.ManageViewModels;
using WebApplication.Services;

namespace WebApplication.Controllers
{
    [Route("/api/students")]
    public class StudentsController : Controller
    {
        private static List<Student> _students;
        public StudentsController()
        {
            if (_students == null)
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
            }
        }

        public ActionResult Index()
        {
           Console.WriteLine("got here.");
           return View();
        }
    }
}