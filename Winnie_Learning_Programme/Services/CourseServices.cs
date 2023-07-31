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
        private WKDbEntities _context;
        public CourseServices(WKDbEntities context)
        {
            _context = context;
        }
        public List<Course> GetCourses()
        {
            List<Course> course = _context.Courses.ToList();
            return course;
        }

        public Course GetCourseById(int id)
        {
            Course course = _context.Courses.Where(x => x.CourseId == id).FirstOrDefault();
            return course;
        }
    }
}