using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication.Models;
using WebApplication.Models.ManageViewModels;
using WebApplication.Services;

namespace WebApplication.Controllers
{
    [Route("/api/courses")]
    public class CoursesController : Controller
    {
        /*public List<Course> GetCourses()
        {
            return new List<Course>
            {
                new Course
                {
                    ID = 1,
                    Title = "Discovery",
                    Artist = "Daft Punk"
                },
                new Course
                {
                    ID = 2,
                    Title = "Discovery",
                    Artist = "Daft Punk"
                }
            };
        }*/
    }
}