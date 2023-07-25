using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataAnnotationsExtensions;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace Winnie_Learning_Programme.Models
{
    public class UserViewModel 
    {
        public User User { get; set; }
        public List<Skills> MySkills { get; set; }
        public List<Education> MyEducation { get; set; }
        public List<Experience> MyExperiences { get; set; }

        public List<Certificates> MyCertificates { get; set; }
        public List<string> Knowledges { get; set; }
    }

    public class User
    {
        public string Name { get; set; }

        [Numeric]
        public int Age { get; set; }
        public string Address { get; set; }
        public string JobTitle { get; set; }
        [Email]
        public string Email { get; set; }
        [Numeric]
        public long PhoneNo { get; set; }
        public string Nationality { get; set; }
        public string AboutMe { get; set; }
        public string SkillRate { get; set; }
        public string UserRole { get; set; }
    }

    public class Education
    {
        public string UniversityName { get; set; }
        public string Major { get; set; }
        public  DateTime StartDate { get; set; }
        public  DateTime EndDate { get; set; }
    }

    public class Experience
    {
        public string CompanyName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; }
        public string Position { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
    }

    public class Projects
    {
        public string ProjectName { get; set; }
        public string Description { get; set; }
    }

    public class Skills
    {
        public string SkillName { get; set; }

        public string SkillCategory { get; set; }
        public int Rate { get; set; }
        public string RateValue { get; set; }
    }

    public class Certificates 
    {
        public string Title { get; set; }
        public string OrgName { get; set; }
        public string Url { get; set; }
        public string Cert { get; set; }
    }
}