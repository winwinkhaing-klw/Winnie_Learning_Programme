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

        public Courses Course { get; set; }

        public List<Courses> Courses { get; set; }
    }
}