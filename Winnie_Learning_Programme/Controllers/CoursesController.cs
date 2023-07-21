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
        public ActionResult Courses()
        {
            var course = new Courses()
            {
                Name = "Programming"
            };
            var viewModel = new CoursesViewModel();
            viewModel.Courses = CourseServices.GetCourses(); 
            return View(viewModel);
        }

        public ActionResult CourseDetail(int id)
        {
            var viewModel = new CoursesViewModel();
            Students student = StudentServices.GetStudentById(id);
            if(student != null)
            {
                viewModel.Student = student;
            }
            return View(viewModel);
        }
    }
}