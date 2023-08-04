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
        private PasswordHasher pwdHasher;

        public UserService(WKDbEntities context)
        {
            _context = context;
            pwdHasher = new PasswordHasher(new WKDbEntities());
        }

        public User GetUserByUserId(int id)
        {
            return _context.Users.FirstOrDefault(p => p.UserId == id);
        }
        public User GetUserByUserName(string name)
        {
            return _context.Users.FirstOrDefault(p => p.Email == name);
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

        public int Register(User userData)
        {
            User user = new User();
            int userId = 0;
            if (userData != null)
            {
                _context.Users.Add(userData);
                _context.SaveChanges();
                userId = userData.UserId;
            }
            return userId;
        }

        public bool isValidAccount(string email, string password)
        {
            User user = _context.Users.Where(x => x.Email == email).FirstOrDefault();
            if(user != null)
            {
                string decryptedPwd = pwdHasher.DecryptPassword(user.Password);
                if (decryptedPwd == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}