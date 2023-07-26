using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Winnie_Learning_Programme.Models;

namespace Winnie_Learning_Programme.Services
{
    public class StudentServices
    {
        public static List<Students> GetStudents()
        {
            List<Students> students = new List<Students>()
            {
                new Students  {
                    StudentId = 1,
                    CourseId = 3,
                    StudentName = "Winnie",
                    Age = 26,
                    Address = "Kalaw",
                    Major = "CS",
                    ImgUrl = "/Content/assets/images/stu6.jpg",
                    Email = "winnie@gmail.com",
                    Phone = 09777777,
                    SocialLink = new List<SocialLink>()
                    {
                        new SocialLink
                        {
                            Name = "facebook",
                            Url = "https://www.facebook.com/"
                        },
                        new SocialLink
                        {
                            Name = "github",
                            Url = "https://www.github.com/"
                        }
                    }
                },
                new Students  {
                    StudentId = 2,
                    CourseId = 2,
                    StudentName = "PPM",
                    Age = 26,
                    Address = "Kalaw",
                    Major = "CS",
                    ImgUrl = "/Content/assets/images/stu2.jpg",
                    Email = "ppm@gmail.com",
                    Phone = 09777777,
                    SocialLink = new List<SocialLink>()
                    {
                        new SocialLink
                        {
                            Name = "facebook",
                            Url = "https://www.facebook.com/"
                        },
                        new SocialLink
                        {
                            Name = "github",
                            Url = "https://www.github.com/"
                        }
                    }
                },
                new Students  {
                    StudentId = 3,
                    CourseId = 4,
                    StudentName = "Clari",
                    Age = 26,
                    Address = "Yangon",
                    Major = "CS",
                    ImgUrl = "/Content/assets/images/stu3.jpg",
                    Email = "clari@gmail.com",
                    Phone = 09777777,
                    SocialLink = new List<SocialLink>()
                    {
                        new SocialLink
                        {
                            Name = "facebook",
                            Url = "https://www.facebook.com/"
                        },
                        new SocialLink
                        {
                            Name = "github",
                            Url = "https://www.github.com/"
                        }
                    }
                },
                new Students  {
                    StudentId = 4,
                    CourseId = 6,
                    StudentName = "Bob",
                    Age = 26,
                    Address = "Taunggyi",
                    Major = "CS",
                    ImgUrl = "/Content/assets/images/stu5.jpg",
                    Email = "bob@gmail.com",
                    Phone = 09777777,
                    SocialLink = new List<SocialLink>()
                    {
                        new SocialLink
                        {
                            Name = "facebook",
                            Url = "https://www.facebook.com/"
                        },
                        new SocialLink
                        {
                            Name = "github",
                            Url = "https://www.github.com/"
                        }
                    }
                },
                new Students  {
                    StudentId = 5,
                    CourseId = 1,
                    StudentName = "Joe",
                    Age = 26,
                    Address = "Mdy",
                    Major = "CS",
                    ImgUrl = "/Content/assets/images/stu1.jpg",
                    Email = "",
                    Phone = 09777777,
                    SocialLink = new List<SocialLink>()
                    {
                        new SocialLink
                        {
                            Name = "facebook",
                            Url = "https://www.facebook.com/"
                        },
                        new SocialLink
                        {
                            Name = "github",
                            Url = "https://www.github.com/"
                        }
                    }
                },
            };

            return students;
        }
        public static Students GetStudentById(int Id)
        {
            Students stu = GetStudents().Where(x => x.StudentId == Id).FirstOrDefault();
            return stu;
        }

        public static Students GetStudentByCourseId(int courseId)
        {
            Students stu = GetStudents().Where(x => x.CourseId == courseId).FirstOrDefault();
            return stu;
        }
    }
}