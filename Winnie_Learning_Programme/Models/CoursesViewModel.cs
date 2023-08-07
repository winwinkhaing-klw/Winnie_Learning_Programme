using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Winnie_Learning_Programme.Models
{
    public class CoursesViewModel
    {
        public List<Student> Students { get; set; }

        public Student Student { get; set; }

        public Course Course { get; set; }

        public List<Course> Courses { get; set; }

        public UserViewModel UserModel { get; set; }
    }
}