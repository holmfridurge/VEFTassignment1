using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Student
    {
        [Required]
        public string SSN { get; set; }
        [Required]
        public string Name { get; set; }
    }
}