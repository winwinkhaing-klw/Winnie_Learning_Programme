using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Winnie_Learning_Programme;

namespace Winnie_Learning_Programme.Services
{
    public class UserService
    {
        private WKDbEntities _context;

        public UserService(WKDbEntities context)
        {
            _context = context;
        }

        public User GetUserByUserId(int id)
        {
            return _context.Users.FirstOrDefault(p => p.UserId == id);
        }
        public User GetUserByUserRole(string role)
        {
            return _context.Users.FirstOrDefault(p => p.UserRole == role);
        }

        public User GetMyInfo()
        {
            User user = new User();
            user = _context.Users.FirstOrDefault();
            return user;
        }

        public List<Experience> GetMyExperience()
        {
            var experience = new List<Experience>();
            experience = _context.Experiences.ToList();
            return experience;
        }
        public List<Education> GetMyEducation()
        {
            var education = new List<Education>();
            education = _context.Educations.ToList();
            return education;
        }

        public List<Skill> GetMySkills()
        {
            List<Skill> skills = new List<Skill>();
            skills = _context.Skills.ToList();
            return skills;
        }

        public List<Certificate> GetMyCertificates()
        {
            var certificates = new List<Certificate>();
            certificates = _context.Certificates.ToList();
            return certificates;
        }
       
        public List<string> GetMyKnowledge()
        {
            List<string> knws = new List<string>();
            knws = _context.Skills.Where(x => x.SkillCategory == "Personal").Select(x=>x.SkillName).ToList();
            return knws;
        }
    }
}