using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Winnie_Learning_Programme.Models;
using Winnie_Learning_Programme;
using Winnie_Learning_Programme.Services;

namespace Winnie_Learning_Programme.Controllers
{
    public class CoursesController : Controller
    {
        private CourseServices courseService;
        public CoursesController()
        {
            courseService = new CourseServices(new WKDbEntities());
        }
        // GET: Movies/Random
        public ActionResult Courses()
        {
            var viewModel = new CoursesViewModel();
            viewModel.Courses = courseService.GetCourses(); 
            return View(viewModel);
        }

        public ActionResult PopularCourse()
        {
            var viewModel = new CoursesViewModel();
            if(courseService.GetCourses().Count > 0 && courseService.GetCourses().Any(x=>x.Category == Constant.Category.Pop))
            {
                viewModel.Courses = courseService.GetCourses().Where(x => x.Category == Constant.Category.Pop).OrderBy(x=>x.CourseName).ToList();
            }
           
            return View(viewModel);
        }
        public ActionResult YourCourse()
        {
            if (!AuthenticationHelper.IsAuthenticated())
            {
                return RedirectToAction("Index", "Home");
            }
            var viewModel = new CoursesViewModel();
            if (courseService.GetCourses().Count > 0 && courseService.GetCourses().Any(x => x.Category == Constant.Category.Mine))
            {
                viewModel.Courses = courseService.GetCourses().Where(x => x.Category == Constant.Category.Mine).OrderBy(x => x.CourseName).ToList();
            }
            return View(viewModel);
        }

        public ActionResult CourseDetail(int id)
        {
            var viewModel = new CoursesViewModel();
            Course course = courseService.GetCourseById(id);
            if(course != null)
            {
                viewModel.Course = course;
            }
            return View(viewModel);
        }
    }
}