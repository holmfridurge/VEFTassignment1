using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace WebApplication.Models
{
    public class StudentsRepository : IStudentsRepository
    {
        private static ConcurrentDictionary<int, Student> _students =
            new ConcurrentDictionary<int, Student>();
        int _nextSSN = 0;

        public StudentsRepository()
        {
            AddStudent(new Student
            {
                Name = "Holmfridur"
            });
            AddStudent(new Student
            {
                Name = "Steinn"
            });
            AddStudent(new Student
            {
                Name = "Tomas"
            });
        }
        public IEnumerable<Student> GetAllStudents()
        {
            return _students.Values;
        }

        public Student AddStudent(Student student)
        {
            student.SSN = _nextSSN++;
            _students.TryAdd(student.SSN, student);
            return student;
        }

    }
}