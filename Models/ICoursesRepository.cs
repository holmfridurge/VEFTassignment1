using System.Collections.Generic;

namespace WebApplication.Models
{
    public interface ICoursesRepository
    {
        // Get a list of courses
        IEnumerable<Course> GetAllCourses();
        // Add a course
        Course AddCourse(Course course);
        // Find a course with specific id
        Course FindCourse(int id);
        // Update a course
        Course UpdateCourse(int id, Course newCourse, Course oldCourse);
        // Remove a course
        Course RemoveCourse(int id);
        // TODO: Get a list of stodents in a course
        // TODO: Add a student to a course
    }

    public interface IStudentsRepository
    {
        IEnumerable<Student> GetAllStudents();

        Student AddStudent(int courseInstanceID, Student student);
        Student FindStudent(string ssn);
    }
}