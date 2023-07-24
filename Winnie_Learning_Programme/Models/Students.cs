using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Winnie_Learning_Programme.Models
{
    public class Students
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public string StudentName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string Major { get; set; }
        public string ImgUrl { get; set; }
    }
}