using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;
using System;

namespace WebApplication.Controllers
{
    [Route("/api/[controller]")]
    public class StudentsController : Controller
    {
        public StudentsController(IStudentsRepository student)
        {
            Student = student;
        }
        public IStudentsRepository Student { get; set; }
        public IEnumerable<Student> GetAllStudents()
        {
            return Student.GetAllStudents();
        }

        [HttpGet("{id}", Name = "GetStudent")]
        public IActionResult GetStudentBySSN(string ssn) {
            var student = Student.FindStudent(ssn);
            if(student == null) 
            {
                return NotFound();
            }
            return new ObjectResult(student);
        }

        [HttpPost]
        public IActionResult AddStudent([FromBody] Student student)
        {
            if(student == null)
            {
                return BadRequest();
            }
            Student.AddStudent(student);
            var location = Url.Link("GetStudent", new { SSN = student.SSN});
            return Created(location, student);
        }
        
    }
}