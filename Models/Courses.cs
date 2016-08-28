using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Course
    {
        [Required]
        public string Name { get; set; }
        // example: "Web Services"
        [Required]
        public string TemplateID { get; set; }
        // example: "T-514-VEFT"
        [Required]
        public int ID { get; set; }
        Student student { get; set; }
        // example: 1
        [Required]
        public DateTime StartDate { get; set; }
        // example: "2016-08-17"
        [Required]
        public DateTime EndDate { get; set; }
        // example: "2016-11-08"
    }
}