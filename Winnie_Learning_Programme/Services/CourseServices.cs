using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Winnie_Learning_Programme.Models;

namespace Winnie_Learning_Programme.Services
{
    public class CourseServices
    {
        public static List<Courses> GetCourses()
        {
            List<Courses> course = new List<Courses>()
            {
                new Courses
                {
                    Id = 1,
                    Name = "Programming",
                    Description = "Programming",
                    Url = ""
                },
                new Courses
                {
                    Id = 2,
                    Name = "Database",
                    Description = "Database",
                    Url = ""
                },
                new Courses
                {
                    Id = 3,
                    Name = "Artificial Intelligence",
                    Description = "Artificial Intelligence",
                    Url = ""
                },
                new Courses
                {
                    Id = 4,
                    Name = "Networking",
                    Description = "Networking",
                    Url = ""
                }
        };
            return course;
        }
    }
}