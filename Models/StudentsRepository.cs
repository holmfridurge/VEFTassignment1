using System.Collections.Generic;
using System.Collections.Concurrent;

namespace WebApplication.Models
{
    public class StudentsRepository : IStudentsRepository
    {
        private static ConcurrentDictionary<string, Student> _students =
            new ConcurrentDictionary<string, Student>();

        public StudentsRepository()
        {
            AddStudent(new Student
            {
                Name = "Holmfridur",
                SSN = "555"
            });
            AddStudent(new Student
            {
                Name = "Steinn",
                SSN = "666"
            });
            AddStudent(new Student
            {
                Name = "Tomas",
                SSN = "777"
            });
        }
        public IEnumerable<Student> GetAllStudents()
        {
            return _students.Values;
        }

        public Student AddStudent(Student student)
        {
            _students.TryAdd(student.SSN, student);
            return student;
        }
        public Student FindStudent(string ssn)
        {
            Student student;
            _students.TryGetValue(ssn, out student);
            return student;
        }

    }
}