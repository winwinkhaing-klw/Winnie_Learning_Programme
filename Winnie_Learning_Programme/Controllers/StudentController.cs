using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Winnie_Learning_Programme.Models;
using Winnie_Learning_Programme.Services;

namespace Winnie_Learning_Programme.Controllers
{
    public class StudentController : Controller
    {
        private CourseServices courseService;
        private StudentServices stuService;
        public StudentController()
        {
            courseService = new CourseServices(new WKDbEntities());
            stuService = new StudentServices(new WKDbEntities());
        }
        // GET: Student
        public ActionResult Index()
        {
            CoursesViewModel viewModel = new CoursesViewModel();
            viewModel.Students = GetAllStudents();
            return View(viewModel);
        }

        private List<Student> GetAllStudents()
        {
            if(stuService.GetStudents().Count > 0)
            {
                return stuService.GetStudents();
            }
            else
            {
                return new List<Student>();
            }
            
        }

        public ActionResult StudentDetails(int id)
        {
            CoursesViewModel viewModel = new CoursesViewModel();
            viewModel.Student = stuService.GetStudentById(id);
            if(viewModel.Student != null)
            {
                viewModel.Course = courseService.GetCourseById(viewModel.Student.CourseId);
            }
            return View(viewModel);
        }

        public ActionResult StudentList()
        {
            CoursesViewModel viewModel = new CoursesViewModel();
            if(GetAllStudents().Count > 0)
            {
                viewModel.Students = GetAllStudents();
            }
            return View(viewModel);
        }
    }
}