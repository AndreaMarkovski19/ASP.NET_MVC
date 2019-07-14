using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AcademyApp.Models;
using AcademyApp.DataAccess;

namespace AcademyApp.Controllers
{
    public class HomeController : Controller
    {
        public IRepository<Student> _studentService;
        public IRepository<Project> _projectService;

        public HomeController(IRepository<Student> studentService, IRepository<Project> projectService)
        {
            _studentService = studentService;
            _projectService = projectService;
        }

        public IActionResult Welcome()
        {            
            return View();
        }

        public IActionResult GetAllStudents()
        {
            List<Project> projects = _projectService.GetAll();
            List<ProjectViewModel> projectModel = new List<ProjectViewModel>();

            foreach (var project in projects)
            {
                projectModel.Add(new ProjectViewModel()
                {
                    Id = project.Id,
                    Title = project.Title,
                    EstimatedTime = project.EstimatedTime,
                    TimeSpent = project.TimeSpent,
                    StudentId = project.StudentId
                });
            }

            List<Student> students = _studentService.GetAll();
            List<StudentViewModel> all = new List<StudentViewModel>();

            foreach (var student in students)
            {
                all.Add(new StudentViewModel()
                {
                    Id = student.Id,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    Age = student.Age,
                    Academy = student.Academy,
                    Projects = projectModel
                });
            }

            AllStudents model = new AllStudents() { All_Students = all };
            return View(model);
        }

        [HttpGet("Home")]
        public IActionResult AddStudents()
        {
            AddStudentViewModel model = new AddStudentViewModel();
            return View(model);
        }

        [HttpPost("Home")]
        public IActionResult AddStudents(AddStudentViewModel model)
        {
            Student student = new Student()
            {                
                FirstName = model.FirstName,
                LastName = model.LastName,
                Age = model.Age,
                Academy = model.Academy,                                
            };

            _studentService.Insert(student);
            return RedirectToAction("GetAllStudents");
        }
       
    }
}
