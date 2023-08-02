using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Winnie_Learning_Programme.Models;

namespace Winnie_Learning_Programme.Services
{
    public class StudentServices
    {
        private WKDbEntities _context;
        public StudentServices(WKDbEntities context)
        {
            _context = context;
        }
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            var stuList = (from stu in _context.Students
                          select stu).ToList();
            if(stuList.Count > 0)
            {
                return stuList;
            }
            return students;
        }
        public Student GetStudentById(int Id)
        {
            Student stu = _context.Students.Where(x => x.StudentId == Id).FirstOrDefault();
            return stu;
        }

        public  Student GetStudentByCourseId(int courseId)
        {
            Student stu = _context.Students.Where(x => x.CourseId == courseId).FirstOrDefault();
            return stu;
        }
    }
}