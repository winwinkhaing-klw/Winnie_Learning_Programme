using Microsoft.Graph.Ediscovery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Winnie_Learning_Programme.Models;
using Winnie_Learning_Programme.Services;

namespace Winnie_Learning_Programme.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CoursesViewModel viewModel = new CoursesViewModel();

            if (CourseServices.GetCourses().Count > 0)
            {
                viewModel.Courses = CourseServices.GetCourses().OrderBy(x => x.Name).ToList();
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
            if (UserService.GetMyInfo() != null)
            {
                viewModel.User = UserService.GetMyInfo();
            }
            if (UserService.GetMyEducation() != null)
            {
                viewModel.MyEducation = UserService.GetMyEducation();
            }
            if (UserService.GetMyCertificates() != null)
            {
                viewModel.MyCertificates = UserService.GetMyCertificates();
            }
            if (UserService.GetMySkills() != null)
            {
                List<Skills> skills = new List<Skills>();
                foreach (var skill in UserService.GetMySkills())
                {
                    switch (skill.Rate)
                    {
                        case 90:
                            skill.RateValue = "skill-1";
                            break;
                        case 65:
                            skill.RateValue = "skill-2";
                            break;
                        case 80:
                            skill.RateValue = "skill-3";
                            break;
                        case 95:
                            skill.RateValue = "skill-5";
                            break;
                        case 85:
                            skill.RateValue = "skill-6";
                            break;
                        case 100:
                            skill.RateValue = "skill-7";
                            break;
                    }
                    skills.Add(skill);
                }
                viewModel.MySkills = skills.Count > 0 ? skills : UserService.GetMySkills();
            }
            if (UserService.GetMyExperience() != null)
            {
                viewModel.MyExperiences = UserService.GetMyExperience();
            }

            List<string> knowledge = new List<string>()
            {
                "Problem Solving",
                "Communication",
                "Troubleshooting and Fixing",
                "Software Documentation",
                "Time Management",
                "Flexibility",
                "Social Networking"
            };
            viewModel.Knowledges = knowledge;
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