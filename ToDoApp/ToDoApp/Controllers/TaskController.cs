using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models.DomainModels;
using ToDoApp.Models.ViewModels;
using Status = ToDoApp.Models.DomainModels.Enums.Status;
using Type = ToDoApp.Models.DomainModels.Enums.Type;

namespace ToDoApp.Controllers
{
    public class TaskController : Controller
    {
        public User _Andrea { get; set; }

        public TaskController()
        {
            User andrea = new User()
            {
                FirstName = "Andrea",
                LastName = "Markovski",
                Age = 35,
                AverageFreeTime = 10,
            };

            Tasks task_01 = new Tasks()
            {
                Title = "Homework01",
                Description = "MVC",
                Priority = Priority.Important,
                Status = Status.NotDone,
                Type = Type.Work,
            };

            SubTasks subtask_01 = new SubTasks()
            {
                Title = "SubTask01",
                Description = "SubTask01-Description",
                Status = Status.NotDone,
            };

            SubTasks subtask_02 = new SubTasks()
            {
                Title = "SubTask02",
                Description = "SubTask02-Description",
                Status = Status.NotDone,
            };

            task_01.SubTasks.Add(subtask_01);
            task_01.SubTasks.Add(subtask_02);

            _Andrea = andrea;
        }

        public IActionResult NotDone()
        {
            var notDoneTasks = _Andrea.ToDoTasks.Where(t => t.Status == Status.NotDone).ToList();

            NotDoneTasksViewModel notDone = new NotDoneTasksViewModel()
            {
                NotDone = notDoneTasks
            };
            return View(notDone);
        }

        public IActionResult InProgress()
        {
            var inProgressTasks = _Andrea.ToDoTasks.Where(t => t.Status == Status.InProgress).ToList();

            InProgressTasksViewModel inProgress = new InProgressTasksViewModel()
            {
                InProgress = inProgressTasks
            };
            return View(inProgress);
        }

        public IActionResult Done()
        {
            var doneTasks = _Andrea.ToDoTasks.Where(t => t.Status == Status.Done).ToList();

            DoneTasksViewModel done = new DoneTasksViewModel()
            {
                Done = doneTasks
            };
            return View(done);
        }

        public IActionResult Statistics()
        {
            return View(_Andrea);
        }

        [HttpGet("Task")]
        public IActionResult AddTask()
        {            
            TaskViewModel model = new TaskViewModel();
            return View(model);
        }
    }
}