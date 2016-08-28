using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;
using System;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    public class CoursesController : Controller
    {
        public CoursesController(ICoursesRepository course)
        {
            Course = course;
        }
        public ICoursesRepository Course { get; set; }
        public IEnumerable<Course> GetAllCourses()
        {
            return Course.GetAllCourses();
        }

        [HttpGet("{id}", Name = "GetCourse")]
        public IActionResult GetCourseById(int id)
        {
            var item = Course.FindCourse(id); //Finds course with given ID
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult AddCourse([FromBody] Course course)
        {
            // FromBody = action parameter to bind a simple type from the request body
            if (course == null)
            {
                return BadRequest();
            }
            Course.AddCourse(course);
            var location = Url.Link("GetCourse", new { id = course.ID });
            return Created(location, course);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCourse(int id, [FromBody] Course newCourse)
        {
            if (newCourse == null)
            {
                return BadRequest();
            }

            newCourse.ID = Convert.ToInt32(id);

            var oldCourse = Course.FindCourse(id);
            if (oldCourse == null)
            {
                return NotFound();
            }

            Course.UpdateCourse(id, newCourse, oldCourse);
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveCourse(int id)
        {
            var course = Course.FindCourse(id);
            if (course == null)
            {
                return NotFound();
            }
            Course.RemoveCourse(id);
            return new NoContentResult();
        }

        //--------------------------------------------------------
        
        [HttpGet("{id}/students")]
        public IEnumerable<Student> GetStudentsInCourse(int id)
        {
            return Course.GetAllStudentsInCourse(id);
        }

        [HttpPost("{courseID}/students")]
        //[Route("{courseInstanceID:int}/students")]
        public IActionResult AddStudent(int courseID, Student student)
        {
            System.Console.WriteLine("komst í Controller: AddStudent");
            Course.AddStudent(courseID, student);
            return null;   // þarf að gera rétt
        }

    }
}