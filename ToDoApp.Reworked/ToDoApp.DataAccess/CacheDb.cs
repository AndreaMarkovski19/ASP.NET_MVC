using System.Collections.Generic;
using ToDoApp.Domain.Enums;
using ToDoApp.Domain.Models;
using Task = ToDoApp.Domain.Models.Task;
using Type = ToDoApp.Domain.Enums.Type;


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

            User andrea = new User()
            {
                Id = 1,
                FirstName = "Andrea",
                LastName = "Markovski",
                Age = 35,
                AverageFreeTime = 10,
            };

            Users.Add(andrea);

            Task task_01 = new Task()
            {
                Id = 1,
                Title = "Homework01",
                Description = "MVC",
                Priority = Priority.Important,
                Status = Status.NotDone,
                Type = Type.Work,
            };

            SubTask subtask_01 = new SubTask()
            {
                Id = 1,
                Title = "Subtask01",
                Description = "MVC",
                SubStatus = SubStatus.NotDone,
            };

            SubTask subtask_02 = new SubTask()
            {
                Id = 2,
                Title = "Subtask02",
                Description = "MVC",
                SubStatus = SubStatus.Done,
            };

            SubTasks.Add(subtask_01);
            SubTasks.Add(subtask_02);

            task_01.SubTasks.Add(subtask_01);
            task_01.SubTasks.Add(subtask_02);

            Task task_02 = new Task()
            {
                Id = 2,
                Title = "Homework02",
                Description = "MVC",
                Priority = Priority.Important,
                Status = Status.NotDone,
                Type = Type.Work,
            };

            SubTask subtask_03 = new SubTask()
            {
                Id = 3,
                Title = "Subtask03",
                Description = "MVC",
                SubStatus = SubStatus.NotDone,
            };

            SubTask subtask_04 = new SubTask()
            {
                Id = 4,
                Title = "Subtask04",
                Description = "MVC",
                SubStatus = SubStatus.Done,
            };

            SubTasks.Add(subtask_03);
            SubTasks.Add(subtask_04);

            task_02.SubTasks.Add(subtask_03);
            task_02.SubTasks.Add(subtask_04);

            Task task_03 = new Task()
            {
                Id = 3,
                Title = "Homework03",
                Description = "MVC",
                Priority = Priority.Important,
                Status = Status.NotDone,
                Type = Type.Work
            };

            SubTask subtask_05 = new SubTask()
            {
                Id = 5,
                Title = "Subtask05",
                Description = "MVC",
                SubStatus = SubStatus.NotDone,
            };

            SubTask subtask_06 = new SubTask()
            {
                Id = 6,
                Title = "Subtask06",
                Description = "MVC",
                SubStatus = SubStatus.Done,
            };

            Task task_04 = new Task()
            {
                Id = 4,
                Title = "Homework04",
                Description = "MVC",
                Priority = Priority.Important,
                Status = Status.Done,
                Type = Type.Work
            };

            Task task_05 = new Task()
            {
                Id = 5,
                Title = "Homework05",
                Description = "MVC",
                Priority = Priority.Important,
                Status = Status.Done,
                Type = Type.Work
            };

            Task task_06 = new Task()
            {
                Id = 6,
                Title = "Homework06",
                Description = "MVC",
                Priority = Priority.Important,
                Status = Status.InProgress,
                Type = Type.Work
            };

            Task task_07 = new Task()
            {
                Id = 7,
                Title = "Homework07",
                Description = "MVC",
                Priority = Priority.Important,
                Status = Status.InProgress,
                Type = Type.Work
            };

            SubTasks.Add(subtask_05);
            SubTasks.Add(subtask_06);

            task_03.SubTasks.Add(subtask_05);
            task_03.SubTasks.Add(subtask_06);

            Tasks.Add(task_01);
            Tasks.Add(task_02);
            Tasks.Add(task_03);
            Tasks.Add(task_04);
            Tasks.Add(task_05);
            Tasks.Add(task_06);
            Tasks.Add(task_07);

            andrea.ToDoTasks.Add(task_01);
            andrea.ToDoTasks.Add(task_02);
            andrea.ToDoTasks.Add(task_03);
            andrea.ToDoTasks.Add(task_04);
            andrea.ToDoTasks.Add(task_05);
            andrea.ToDoTasks.Add(task_06);
            andrea.ToDoTasks.Add(task_07);

            UserId = 1;
            TaskId = 7;
            SubTaskId = 6;
        }
    }
}
