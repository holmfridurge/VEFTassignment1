using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace WebApplication.Models
{
    public class CoursesRepository : ICoursesRepository
    {
        private static ConcurrentDictionary<int, Course> _courses =
              new ConcurrentDictionary<int, Course>();
        int _nextID = 0;

        public CoursesRepository()
        {
            AddCourse(new Course
            {
                //ID = 1,
                Name = "Web services",
                TemplateID = "T-514-VEFT",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(3)
            });
            AddCourse(new Course
            {
                //ID = 2,
                Name = "Final project",
                TemplateID = "T-404-LOKA",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(3)
            });
            AddCourse(new Course
            {
                //ID = 3,
                Name = "Advanced software engineering",
                TemplateID = "T-730-ASEN",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(3)
            });
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return _courses.Values;
        }

        public Course AddCourse(Course course)
        {
            course.ID = _nextID++;
            _courses.TryAdd(course.ID, course);
            return course;
        }

        public Course FindCourse(int id)
        {
            Course course;
            _courses.TryGetValue(id, out course); // Helper function for concurrent dictionary
            return course;
        }

        public Course RemoveCourse(int id)
        {
            Course course;
            // Attempts to remove and return the value that has the specified key.
            // Finds the object we want to remove.
            _courses.TryRemove(id, out course);
            // Then we return the object.
            return course;
        }

        public Course UpdateCourse(int id, Course newCourse, Course oldCourse)
        {
            _courses.TryUpdate(id, newCourse, oldCourse);
            return newCourse;
        }
    }
}