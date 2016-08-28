using System.Collections.Generic;

namespace WebApplication.Models
{
    public interface IStudentsRepository
    {
        IEnumerable<Student> GetAllStudents();

        Student AddStudent(Student student);
        Student FindStudent(string ssn);
    }
}