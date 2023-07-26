﻿using System;
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
        // GET: Student
        public ActionResult Index()
        {
            CoursesViewModel viewModel = new CoursesViewModel();
            viewModel.Students = GetAllStudents();
            return View(viewModel);
        }

        private List<Students> GetAllStudents()
        {
            if(StudentServices.GetStudents().Count > 0)
            {
                return StudentServices.GetStudents();
            }
            else
            {
                return new List<Students>();
            }
            
        }

        public ActionResult StudentDetails(int id)
        {
            CoursesViewModel viewModel = new CoursesViewModel();
            viewModel.Student = StudentServices.GetStudentById(id);
            if(viewModel.Student != null)
            {
                viewModel.Course = CourseServices.GetCourseById(viewModel.Student.CourseId);
            }
            return View(viewModel);
        }
    }
}