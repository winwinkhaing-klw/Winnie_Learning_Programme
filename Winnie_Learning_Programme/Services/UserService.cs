﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Winnie_Learning_Programme.Models;

namespace Winnie_Learning_Programme.Services
{
    public class UserService
    {
        public static User GetMyInfo()
        {
            User user = new User();
            user.Name = "Win Win Khaing";
            user.Age = 26;
            user.Email = "winwinkhaing.mm25@gmail.com";
            user.JobTitle = "Software Developer";
            user.Address = "Gandamar Street, Sanchaung Township";
            user.AboutMe = "I am a Software Developer with more than 4 years of experience in software development, web application development and mobile application development. Currently, I am working at NTT Myanmar as Associate Software Application Development Engineer specializing in software development. Experienced with all stages of the development cycle for dynamic web projects.Well - versed in numerous programming languages including C#, OOP, JavaScript, SQL. Strong background in software development and production issues fixing.";
            user.PhoneNo = 09252587215;
            user.Nationality = "Myanmar";
            return user;
        }
        public static List<Experience> GetMyExperience()
        {
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
            return experience;
        }
        public static List<Education> GetMyEducation()
        {
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
            return education;
        }

        public static List<Skills> GetMySkills()
        {
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
            return skills;
        }

        public static List<Certificates> GetMyCertificates()
        {
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
            return certificates;
        }
       
    }
}