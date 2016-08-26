using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace WebApplication.Models
{
    public class CoursesRepository : ICoursesRepository
    {
        private static ConcurrentDictionary<string, Course> _courses =
              new ConcurrentDictionary<string, Course>();
        int _nextID = 0;

        public CoursesRepository()
        {
            AddCourse(new Course { Name = "Course 1" });
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return _courses.Values;
        }

        public void AddCourse(Course item)
        {
            item.ID = _nextID++;
            _courses[item.ID.ToString()] = item;
        }

        public Course FindCourse(string key)
        {
            Course item;
            _courses.TryGetValue(key, out item);
            return item;
        }

        public Course RemoveCourse(string key)
        {
            Course item;
            _courses.TryRemove(key, out item);
            return item;
        }

        public void UpdateCourse(Course item)
        {
            _courses[item.ID.ToString()] = item;
        }
    }
}