using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models.DomainModels;
using Status = ToDoApp.Models.DomainModels.Enums.Status;
using Type = ToDoApp.Models.DomainModels.Enums.Type;

namespace ToDoApp.Controllers
{
    public class UserController : Controller
    {
        public List<User> _usersDb;
        public List<Tasks> _tasksDb;

        public UserController()
        {
            _usersDb = new List<User>()
            {
                new User()
                {
                FirstName = "Andrea",
                LastName = "Markovski",
                Age = 35,
                AverageFreeTime = 10,
                ToDoTasks = _tasksDb
                },
                new User()
                {
                FirstName = "Martin",
                LastName = "Stojanovski",
                Age = 27,
                AverageFreeTime = 4,
                ToDoTasks = _tasksDb
                },
                new User()
                {
                FirstName = "Sandra",
                LastName = "Atanasova",
                Age = 31,
                AverageFreeTime = 7,
                ToDoTasks = _tasksDb
                },
            };

            _tasksDb = new List<Tasks>()
            {
                new Tasks
                {
                    Title = "Homework01",
                    Description = "MVC",
                    Priority = Priority.Important,
                    Status = Status.NotDone,
                    Type = Type.Work,
                },

                new Tasks
                {
                    Title = "Homework02",
                    Description = "Models",
                    Priority = Priority.Important,
                    Status = Status.NotDone,
                    Type = Type.Work
                },

                new Tasks
                {
                    Title = "Homework03",
                    Description = "Views",
                    Priority = Priority.Important,
                    Status = Status.Done,
                    Type = Type.Work
                }
            };
        }

        public IActionResult NotDone()
        {
            User andrea = _usersDb[0];
            return View(andrea);
        }
        public IActionResult InProgress()
        {
            return View();
        }
        public IActionResult Done()
        {
            return View();
        }
        public IActionResult Statistics()
        {
            User andrea = _usersDb[0];
            ViewData["Message"] = "User - Stats.";
            return View(andrea);
        }
    }
}