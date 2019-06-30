using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Domain.Enums;
using ToDoApp.Domain.Models;
using Task = ToDoApp.Domain.Models.Task;
using Type = ToDoApp.Domain.Enums.Type;
using ToDoApp.Domain;


namespace ToDoApp.DataAccess
{
    public static class CacheDb
    {
        public static List<User> Users = new List<User>(); 
        public static List<Task> Tasks = new List<Task>();
        public static List<SubTask> SubTasks = new List<SubTask>();
        public static int UserId;
        public static int TaskId;
        public static int SubTaskId;

        static CacheDb()
        {
            Users = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    FirstName = "Andrea",
                    LastName = "Markovski",
                    Age = 35,
                    AverageFreeTime = 10,
                    ToDoTasks = new List<Domain.Models.Task>()
                    {
                        Tasks[0], Tasks[1], Tasks[2], Tasks[3], Tasks[4],
                        Tasks[5], Tasks[6], Tasks[7], Tasks[8]
                    }
                },
            };

            Tasks = new List<Task>()
            {
                new Task()
                {
                    Id = 1,
                    Title = "Homework01",
                    Description = "MVC",
                    Priority = Priority.Important,
                    Status = Status.NotDone,
                    Type = Type.Work,
                    SubTasks = new List<SubTask>()
                    {
                        SubTasks[0], SubTasks[1]
                    }
                },
                new Task()
                {
                    Id = 2,
                    Title = "Homework02",
                    Description = "MVC",
                    Priority = Priority.Important,
                    Status = Status.NotDone,
                    Type = Type.Work,
                    SubTasks = new List<SubTask>()
                    {
                        SubTasks[2], SubTasks[3]
                    }
                },
                new Task()
                {
                    Id = 3,
                    Title = "Homework03",
                    Description = "MVC",
                    Priority = Priority.Important,
                    Status = Status.NotDone,
                    Type = Type.Work
                },
                new Task()
                {
                    Id = 4,
                    Title = "Homework04",
                    Description = "MVC",
                    Priority = Priority.Important,
                    Status = Status.InProgress,
                    Type = Type.Work
                },
                new Task()
                {
                    Id = 5,
                    Title = "Homework05",
                    Description = "MVC",
                    Priority = Priority.Important,
                    Status = Status.InProgress,
                    Type = Type.Work
                },
                new Task()
                {
                    Id = 6,
                    Title = "Homework06",
                    Description = "MVC",
                    Priority = Priority.Important,
                    Status = Status.InProgress,
                    Type = Type.Work
                },
                new Task()
                {
                    Id = 7,
                    Title = "Homework07",
                    Description = "MVC",
                    Priority = Priority.Important,
                    Status = Status.Done,
                    Type = Type.Work
                },
                new Task()
                {
                    Id = 8,
                    Title = "Homework08",
                    Description = "MVC",
                    Priority = Priority.Important,
                    Status = Status.Done,
                    Type = Type.Work
                },
                new Task()
                {
                    Id = 9,
                    Title = "Homework09",
                    Description = "MVC",
                    Priority = Priority.Important,
                    Status = Status.Done,
                    Type = Type.Work
                },
            };

            SubTasks = new List<SubTask>()
            {
                new SubTask()
                {
                    Id = 1,
                    Title = "Subtask01",
                    Description = "MVC",
                    Status = Status.NotDone,
                },
                new SubTask()
                {
                    Id = 2,
                    Title = "Subtask02",
                    Description = "MVC",
                    Status = Status.Done,
                },
                new SubTask()
                {
                    Id = 3,
                    Title = "Subtask03",
                    Description = "MVC",
                    Status = Status.NotDone,
                },
                new SubTask()
                {
                    Id = 4,
                    Title = "Subtask04",
                    Description = "MVC",
                    Status = Status.InProgress,
                },
            };

            UserId = 1;
            TaskId = 9;
            SubTaskId = 4;
        }
    }
}
