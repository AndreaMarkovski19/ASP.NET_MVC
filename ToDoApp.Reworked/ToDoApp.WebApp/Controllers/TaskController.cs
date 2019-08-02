using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.DataAccess;
using ToDoApp.DataAccess.Repositories;
using ToDoApp.Domain.Enums;
using ToDoApp.Domain.Models;
using ToDoApp.Services.Services;
using ToDoApp.WebApp.Models;
using Task = ToDoApp.Domain.Models.Task;

namespace ToDoApp.WebApp.Controllers
{
    public class TaskController : Controller
    {
        public IUserService _userService;
        public ITaskService _taskService;

        public TaskController(IUserService userService, ITaskService taskService)
        {
            _userService = userService;
            _taskService = taskService;
        }

        public IActionResult NotDone()
        {
            List<Task> allTasks = _taskService.GetAllTasks()
                .Where(t => t.Status == Status.NotDone)
                .ToList();
            List<TaskViewModel> notDone = new List<TaskViewModel>();
            foreach (var task in allTasks)
            {
                TaskViewModel taskForList = new TaskViewModel
                {
                    Title = task.Title,
                    Description = task.Description,
                    Priority = task.Priority,
                    Status = task.Status,
                    Type = task.Type,
                };
                notDone.Add(taskForList);
            }

            NotDoneTasksViewModel model = new NotDoneTasksViewModel() { NotDone = notDone };
            return View(model);
        }

        public IActionResult InProgress()
        {
            List<Task> allTasks = _taskService.GetAllTasks()
                .Where(t => t.Status == Status.InProgress)
                .ToList();
            List<TaskViewModel> inProgress = new List<TaskViewModel>();
            foreach (var task in allTasks)
            {
                TaskViewModel taskForList = new TaskViewModel
                {
                    Title = task.Title,
                    Description = task.Description,
                    Priority = task.Priority,
                    Status = task.Status,
                    Type = task.Type,
                };
                inProgress.Add(taskForList);
            }

            InProgressTasksViewModel model = new InProgressTasksViewModel() { InProgress = inProgress };
            return View(model);
        }

        public IActionResult Done()
        {
            List<Task> allTasks = _taskService.GetAllTasks()
               .Where(t => t.Status == Status.Done)
               .ToList();
            List<TaskViewModel> done = new List<TaskViewModel>();
            foreach (var task in allTasks)
            {
                TaskViewModel taskForList = new TaskViewModel
                {
                    Title = task.Title,
                    Description = task.Description,
                    Priority = task.Priority,
                    Status = task.Status,
                    Type = task.Type,
                };
                done.Add(taskForList);
            }

            DoneTasksViewModel model = new DoneTasksViewModel() { Done = done };
            return View(model);
        }

        public IActionResult GetAllTasks()
        {
            List<Task> allTasks = _taskService.GetAllTasks()
               .ToList();
            List<TaskViewModel> all = new List<TaskViewModel>();
            foreach (var task in allTasks)
            {
                TaskViewModel allTasksForList = new TaskViewModel
                {
                    Title = task.Title,
                    Description = task.Description,
                    Priority = task.Priority,
                    Status = task.Status,
                    Type = task.Type,
                };
                all.Add(allTasksForList);
            }

            AllTasksViewModel model = new AllTasksViewModel() { AllTasks = all };
            return View(model);
        }

        [HttpGet("Task")]
        public IActionResult AddTask()
        {
            AddTaskViewModel model = new AddTaskViewModel();
            return View(model);
        }

        [HttpPost("Task")]
        public IActionResult AddTask(AddTaskViewModel model)
        {
            Task task = new Task()
            {
                Title = model.Title,
                Description = model.Description,
                Priority = model.Priority,
                Status = model.Status,
                Type = model.Type,
            };

            _taskService.CreateNewTask(task);

            return View("_ThankYou");
        }

        //[HttpGet("Task")]
        public IActionResult TaskDetails(int id)
        {

            return View();
        }

        //[HttpPost("Task")]
        public IActionResult TaskDetails(TaskDetailsViewModel model)
        {

            return View();
        }
    }
}
