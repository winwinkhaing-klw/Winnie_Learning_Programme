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
        public List<Skill> MySkills { get; set; }
        public string SkillValue { get; set; }
        public List<Education> MyEducation { get; set; }
        public List<Experience> MyExperiences { get; set; }
        public List<Certificate> MyCertificates { get; set; }
        public List<string> Knowledges { get; set; }
        public Mail Mail { get; set; }
    }
}