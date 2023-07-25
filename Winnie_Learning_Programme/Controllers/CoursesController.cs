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
            var viewModel = new CoursesViewModel();
            viewModel.Courses = CourseServices.GetCourses(); 
            return View(viewModel);
        }

        public ActionResult PopularCourse()
        {
            var viewModel = new CoursesViewModel();
            if(CourseServices.GetCourses().Count > 0 && CourseServices.GetCourses().Any(x=>x.Category == Constant.Category.Pop))
            {
                viewModel.Courses = CourseServices.GetCourses().Where(x => x.Category == Constant.Category.Pop).OrderBy(x=>x.Name).ToList();
            }
           
            return View(viewModel);
        }
        public ActionResult YourCourse()
        {
            var viewModel = new CoursesViewModel();
            if (CourseServices.GetCourses().Count > 0 && CourseServices.GetCourses().Any(x => x.Category == Constant.Category.Mine))
            {
                viewModel.Courses = CourseServices.GetCourses().Where(x => x.Category == Constant.Category.Mine).OrderBy(x => x.Name).ToList();
            }
            return View(viewModel);
        }

        public ActionResult CourseDetail(int id)
        {
            var viewModel = new CoursesViewModel();
            Courses course = CourseServices.GetCourseById(id);
            if(course != null)
            {
                viewModel.Course = course;
            }
            return View(viewModel);
        }
    }
}