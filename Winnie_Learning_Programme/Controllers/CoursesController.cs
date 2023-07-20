using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Winnie_Learning_Programme.Models;
using Winnie_Learning_Programme.Services;

namespace Winnie_Learning_Programme.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Index()
        {
            var course = new Courses()
            {
                Name = "Programming"
            };
            var viewModel = new CoursesViewModel();
            viewModel.Courses = CourseServices.GetCourses(); 
            return View(viewModel);
        }

        public ActionResult Detail(int id)
        {
            List<Students> students = new List<Students>()
            {
                new Students  {
                    StudentId = 1,
                    StudentName = "Winnie",
                    Age = 26,
                    Address = "Kalaw",
                    Major = "CS"
                },
                new Students  {
                    StudentId = 2,
                    StudentName = "PPM",
                    Age = 26,
                    Address = "Kalaw",
                    Major = "CS"
                },
                new Students  {
                    StudentId = 3,
                    StudentName = "Clari",
                    Age = 26,
                    Address = "Yangon",
                    Major = "CS"
                },
                new Students  {
                    StudentId = 4,
                    StudentName = "Bob",
                    Age = 26,
                    Address = "Taunggyi",
                    Major = "CS"
                },
                new Students  {
                    StudentId = 5,
                    StudentName = "Joe",
                    Age = 26,
                    Address = "Mdy",
                    Major = "CS"
                },
            };
            return View();
        }
    }
}