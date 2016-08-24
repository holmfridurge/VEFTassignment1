using System;

namespace WebApplication.Models
{
    public class Course
    {
        public string Name { get; set; }
        // example: "Web Services"
        public string TemplateID { get; set; }
        // example: "T-514-VEFT"
        public int ID { get; set; }
        // example: 1
        public DateTime StartDate { get; set; }
        // example: "2016-08-17"
        public DateTime EndDate { get; set; }
        // example: "2016-11-08"
    }
}