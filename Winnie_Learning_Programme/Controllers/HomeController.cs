using Microsoft.Graph.Ediscovery;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Configuration;
using System.Web.Mvc;
using Winnie_Learning_Programme.Models;
using Winnie_Learning_Programme.Services;

namespace Winnie_Learning_Programme.Controllers
{
    public class HomeController : Controller
    {
        private UserService userService;
        private CourseServices courseService;
        public HomeController()
        {
            userService = new UserService(new WKDbEntities());
            courseService = new CourseServices(new WKDbEntities());
        }

        public ActionResult Index()
        {
            CoursesViewModel viewModel = new CoursesViewModel();

            if (courseService.GetCourses().Count > 0)
            {
                viewModel.Courses = courseService.GetCourses().OrderBy(x => x.CourseName).ToList();
            }

            if (StudentServices.GetStudents().Count > 0)
            {
                viewModel.Students = StudentServices.GetStudents().OrderBy(x => x.StudentId).ToList();
            }
            return View(viewModel);
        }

        public ActionResult Portfolio()
        {
            UserViewModel viewModel = new UserViewModel();
            if (userService.GetMyInfo() != null)
            {
                viewModel.User = userService.GetMyInfo();
            }
            if (userService.GetMyEducation().Count > 0)
            {
                viewModel.MyEducation = userService.GetMyEducation();
            }
            if (userService.GetMyCertificates().Count > 0)
            {
                viewModel.MyCertificates = userService.GetMyCertificates();
            }
            if (userService.GetMySkills().Count > 0)
            {
                viewModel.MySkills = userService.GetMySkills();
            }
            if (userService.GetMyExperience().Count > 0)
            {
                viewModel.MyExperiences = userService.GetMyExperience();
            }
             viewModel.Knowledges = userService.GetMyKnowledge();
            return View(viewModel);
        }

        public FileResult DownloadFile(string fileName)
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(@"D:\my learning\Winnie_Learning_Programme\Winnie_Learning_Programme\App_Data\\Win Win Khaing - CV.pdf");
            fileName = "Win Win Khaing - CV.pdf";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }

        public ActionResult About()
        {
            CoursesViewModel viewModel = new CoursesViewModel();
            if (StudentServices.GetStudents().Count > 0)
            {
                viewModel.Students = StudentServices.GetStudents().OrderBy(x => x.StudentId).ToList();
            }
            return View(viewModel);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}