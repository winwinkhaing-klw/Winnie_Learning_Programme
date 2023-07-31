using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Winnie_Learning_Programme.Models
{
    public class CoursesViewModel
    {
        public List<Students> Students { get; set; }

        public Students Student { get; set; }

        public Course Course { get; set; }

        public List<Course> Courses { get; set; }
    }
}