using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

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
        IEnumerable<Course> GetAllCourses()
        {
            return Course.GetAllCourses();
        }

        [HttpGet("{id}", Name = "GetCourse")]
        public IActionResult GetCourseById(string id)
        {
            var item = Course.FindCourse(id); //Finds the id of the course
            if (item == null)
            {
                return NotFound(); // glosa fall
            }
            return new ObjectResult(item); // glosa fall
        }

        [HttpPost]
        public IActionResult AddCourse([FromBody] Course item)
        {
            // glosa FromBody
            if (item == null)
            {
                return BadRequest();
            }
            Course.AddCourse(item);
            return CreatedAtRoute("GetCourse", new { id = item.TemplateID }, item);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCourse(string id, [FromBody] Course item)
        {
            if (item == null || item.ID.ToString() != id)
            {
                return BadRequest();
            }

            var course = Course.FindCourse(id);
            if (course == null)
            {
                return NotFound();
            }

            Course.UpdateCourse(item);
            return new NoContentResult(); // glosa fall
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveCourse(string id)
        {
            var course = Course.FindCourse(id);
            if (course == null)
            {
                return NotFound();
            }
            Course.RemoveCourse(id);
            return new NoContentResult();
        }
    }
}