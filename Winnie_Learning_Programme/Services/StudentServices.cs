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
                    StudentName = "Winnie",
                    Age = 26,
                    Address = "Kalaw",
                    Major = "CS",
                    ImgUrl = "/Content/assets/images/stu6.jpg"
                },
                new Students  {
                    StudentId = 2,
                    StudentName = "PPM",
                    Age = 26,
                    Address = "Kalaw",
                    Major = "CS",
                    ImgUrl = "/Content/assets/images/stu2.jpg"
                },
                new Students  {
                    StudentId = 3,
                    StudentName = "Clari",
                    Age = 26,
                    Address = "Yangon",
                    Major = "CS",
                    ImgUrl = "/Content/assets/images/stu3.jpg"
                },
                new Students  {
                    StudentId = 4,
                    StudentName = "Bob",
                    Age = 26,
                    Address = "Taunggyi",
                    Major = "CS",
                    ImgUrl = "/Content/assets/images/stu5.jpg"
                },
                new Students  {
                    StudentId = 5,
                    StudentName = "Joe",
                    Age = 26,
                    Address = "Mdy",
                    Major = "CS",
                    ImgUrl = "/Content/assets/images/stu1.jpg"
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