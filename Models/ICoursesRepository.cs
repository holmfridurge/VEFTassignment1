using System.Collections.Generic;

namespace WebApplication.Models
{
    public interface ICoursesRepository
    {
        // Get a list of courses
        IEnumerable<Course> GetAllCourses();
        // Add a course
        void AddCourse(Course item);
        // Find a course with specific id
        Course FindCourse(string key);
        // Update a course
        void UpdateCourse(Course item);
        // Remove a course
        Course RemoveCourse(string key);
        // TODO: Get a list of stodents in a course
        // TODO: Add a student to a course
    }
}