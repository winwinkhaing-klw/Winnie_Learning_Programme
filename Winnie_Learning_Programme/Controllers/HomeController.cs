using Microsoft.Graph.Ediscovery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Winnie_Learning_Programme.Models;


namespace Winnie_Learning_Programme.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
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
            return View();
        }

        public ActionResult Portfolio()
        {
            UserViewModel viewModel = new UserViewModel();

            viewModel.Name = "Win Win Khaing";
            viewModel.Age = 26;
            viewModel.Email = "winwinkhaing.mm25@gmail.com";
            viewModel.JobTitle = "Software Developer";
            viewModel.Address = "Gandamar Street, Sanchaung Township";
            viewModel.AboutMe = "I am a Software Developer with more than 4 years of experience in software development, web application development and mobile application development. Currently, I am working at NTT Myanmar as Associate Software Application Development Engineer specializing in software development. Experienced with all stages of the development cycle for dynamic web projects.Well - versed in numerous programming languages including C#, OOP, JavaScript, SQL. Strong background in software development and production issues fixing.";
            viewModel.PhoneNo = 09252587215;
            viewModel.Nationality = "Myanmar";

            var education = new List<Education>()
            {
                new Education
                {
                    UniversityName = "University Of computer Studies, Taunggyi",
                    Major = "Computer Scenice",
                    StartDate = Convert.ToDateTime("2013/02/01"),
                    EndDate = Convert.ToDateTime("2018/02/01")
                }
            };

            var experience = new List<Experience>()
            {
                new Experience
                {
                    CompanyName = "NTT",
                    StartDate = Convert.ToDateTime("2020/02/01"),
                    EndDate = DateTime.Now,
                    Location = "Yangon, Myanmar",
                    Position = "Associate Software Engineer",
                },
                new Experience
                {
                    CompanyName = "AYA Bank River View",
                    StartDate = Convert.ToDateTime("2018/02/01"),
                    EndDate = Convert.ToDateTime("2020/01/31"),
                    Location = "Yangon, Myanmar",
                    Position = "Mobile Developer"

                },
                new Experience
                {
                    CompanyName = "Max Myanmar",
                    StartDate = Convert.ToDateTime("2017/07/01"),
                    EndDate = Convert.ToDateTime("2017/10/31"),
                    Location = "Yangon, Myanmar",
                    Position = "Internship Student"
                }
            };
            var certificates = new List<Certificates>(){
                new Certificates
                {
                    Title = "The Complete ASP.NET MVC 5 Course",
                    OrgName = "Udemy",
                    Url = "https://www.udemy.com/certificate/UC-052bd256-022e-4dd3-b19d-216c9bc84ad1/",
                    Cert = ""
                },
                 new Certificates
                 {
                    Title = "JavaScript - Basics to Advanced step by step",
                    OrgName = "Udemy",
                    Url = "https://www.udemy.com/certificate/UC-411065ab-e996-4e53-9c1f-598a88012883/",
                    Cert = ""
                },
                 new Certificates{
                    Title = "Microsoft Certified Azure Fundamentals",
                    OrgName = "Microsoft",
                    Url = "",
                    Cert = ""
                },
                new Certificates{
                    Title = "Front-End JavaScript Frameworks: Angular",
                    OrgName = "The Hong Kong University of Science and Technology",
                    Url = "https://www.coursera.org/account/accomplishments/verify/H4JLCRUR6H8E",
                    Cert = ""
                },
                new Certificates {
                    Title = "Speak English Professionally: In Person, Online & On the Phone",
                    OrgName = "Georgia Institute of Technology",
                    Url = "https://www.coursera.org/account/accomplishments/verify/794VLWHL9CYK",
                    Cert = ""
                },
                 new Certificates{
                    Title = "JavaScript And PHP Programming Complete Course",
                    OrgName = "Udemy",
                    Url = "https://www.udemy.com/certificate/UC-3eb53b47-853e-4ce2-8968-37df3ee20714/",
                    Cert = ""
                },
                 new Certificates{
                    Title = "Front-End Web UI Frameworks and Tools: Bootstrap 4",
                    OrgName = "The Hong Kong University of Science and Technology",
                    Url = "https://www.coursera.org/account/accomplishments/verify/C3R47ULT9ETQ",
                    Cert = ""
                },
                new Certificates {
                    Title = "Building AI Powered Chatbots Without Programming",
                    OrgName = "Coursera",
                    Url = "https://coursera.org/share/b041527667fc39bb1a17dca8111dd806",
                    Cert = ""
                },
                 new Certificates{
                    Title = "IOS application development",
                    OrgName = "New Horizons",
                    Url = "",
                    Cert = ""
                },
                new Certificates {
                    Title = "Professional Android Developer Course",
                    OrgName = "FairWay Technology",
                    Url = "",
                    Cert = ""
                },
                 new Certificates{
                    Title = "Create a Members Only Blog using PHP, MySQL, & AJAX",
                    OrgName = "Udemy",
                    Url = "https://www.udemy.com/certificate/UC-697e616d-5043-40ad-8ffe-cdc305ac3c10/",
                    Cert = ""
                }

            };
            var skills = new List<Skills>()
            {
                new Skills
                {
                    SkillName = "C#",
                    SkillCategory = "Technology",
                    Rate = 90
                },
                 new Skills
                {
                    SkillName = "OOP",
                    SkillCategory = "Technology",
                    Rate = 90
                }, new Skills
                {
                    SkillName = "SQL",
                    SkillCategory = "Technology",
                    Rate = 90
                }, new Skills
                {
                    SkillName = "JavaScript",
                    SkillCategory = "Technology",
                    Rate = 90
                }, new Skills
                {
                    SkillName = "ASP.Net MVC",
                    SkillCategory = "Technology",
                    Rate = 90
                }, new Skills
                {
                    SkillName = "AJAX",
                    SkillCategory = "Technology",
                    Rate = 90
                }, new Skills
                {
                    SkillName = "JQuery",
                    SkillCategory = "Technology",
                    Rate = 90
                }, new Skills
                {
                    SkillName = "MSSQL",
                    SkillCategory = "Technology",
                    Rate = 90
                }, new Skills
                {
                    SkillName = "HTML",
                    SkillCategory = "Technology",
                    Rate = 90
                }, new Skills
                {
                    SkillName = "CSS",
                    SkillCategory = "Technology",
                    Rate = 90
                }, new Skills
                {
                    SkillName = "AngularJS",
                    SkillCategory = "Technology",
                    Rate = 90
                }, new Skills
                {
                    SkillName = "TypeScript",
                    SkillCategory = "Technology",
                    Rate = 90
                }, new Skills
                {
                    SkillName = "Git",
                    SkillCategory = "Technology",
                    Rate = 90
                }, new Skills
                {
                    SkillName = "TFS",
                    SkillCategory = "Technology",
                    Rate = 90
                }, new Skills
                {
                    SkillName = "Reporting",
                    SkillCategory = "Technology",
                    Rate = 90
                }, new Skills
                {
                    SkillName = "React Native",
                    SkillCategory = "Technology",
                    Rate = 90
                }, new Skills
                {
                    SkillName = "Software Development",
                    SkillCategory = "Technology",
                    Rate = 90
                }, new Skills
                {
                    SkillName = "Mobile Development",
                    SkillCategory = "Technology",
                    Rate = 90
                }, new Skills
                {
                    SkillName = "Automation Test",
                    SkillCategory = "Technology",
                    Rate = 90
                },
                new Skills
                {
                    SkillName = "PHP",
                    SkillCategory = "Technology",
                    Rate = 80
                }
            };
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
            viewModel.MyEducation = education;
            viewModel.MyExperiences = experience;
            viewModel.MyCertificates = certificates;
            viewModel.MySkills = skills;
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
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}