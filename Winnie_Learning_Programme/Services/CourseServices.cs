using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Winnie_Learning_Programme.Models;

namespace Winnie_Learning_Programme.Services
{
    public class CourseServices
    {
        public static List<Courses> GetCourses()
        {
            List<Courses> course = new List<Courses>()
            {
                new Courses
                {
                    Id = 1,
                    Name = "Programming",
                    Description = "Programming",
                    Url = "/Content/assets/images/course1.jpg",
                    Price = 100,
                    Category = Constant.Category.Pop
                },
                new Courses
                {
                    Id = 2,
                    Name = "Database",
                    Description = "Database",
                    Url = "/Content/assets/images/course2.png",
                    Price = 90,
                    Category = Constant.Category.Mine
                },
                new Courses
                {
                    Id = 3,
                    Name = "Artificial Intelligence",
                    Description = "Artificial Intelligence",
                    Url = "/Content/assets/images/course10.jpg",
                    Price = 150,
                    Category = Constant.Category.Fav
                },
                new Courses
                {
                    Id = 4,
                    Name = "Networking",
                    Description = "Networking",
                    Url = "/Content/assets/images/course8.jpg",
                    Category = Constant.Category.Pop,
                    Price = 160
                },
                 new Courses
                {
                    Id = 5,
                    Name = "Cloud Computing",
                    Description = "Cloud Computing",
                    Url = "/Content/assets/images/course9.jpg",
                    Category = Constant.Category.Pop,
                    Price = 110
                },
                  new Courses
                {
                    Id = 6,
                    Name = "Data Structure",
                    Description = "Data Structure",
                    Url = "/Content/assets/images/course3.png",
                    Category = Constant.Category.Pop,
                    Price = 150
                },
                   
                new Courses
                {
                    Id = 7,
                    Name = "Hacking",
                    Description = "Hacking",
                    Url = "/Content/assets/images/course4.png",
                    Price = 110,
                    Category = Constant.Category.Mine
                },
                    
                new Courses
                {
                    Id = 0,
                    Name = "Security",
                    Description = "Security",
                    Url = "/Content/assets/images/course5.png",
                    Price = 110,
                    Category = Constant.Category.Mine
                },
                    
                new Courses
                {
                    Id = 8,
                    Name = "Database Management System",
                    Description = "Database Management System",
                    Url = "/Content/assets/images/course6.jpg",
                    Price = 110,
                    Category = Constant.Category.Mine
                }, 
                new Courses
                {
                    Id = 9,
                    Name = "Git Version Control System",
                    Description = "Git Version Control System",
                    Url = "/Content/assets/images/course7.png",
                    Price = 90
                }
        };
            return course;
        }

        public static Courses GetCourseById(int id)
        {
            Courses course = GetCourses().Where(x => x.Id == id).FirstOrDefault();
            return course;
        }

        public static Courses GetCourseByStudentId(int id)
        {
            Courses course = GetCourses().Where(x => x.StudentId == id).FirstOrDefault();
            return course;
        }
    }
}