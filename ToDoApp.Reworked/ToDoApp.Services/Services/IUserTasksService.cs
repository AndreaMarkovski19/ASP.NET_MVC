using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Domain.Models;
using Task = ToDoApp.Domain.Models.Task;

namespace ToDoApp.Services.Services
{
    public interface IUserTasksService
    {
        List<Task> GetAllUserTasks(int userId);
        List<Task> GetUserDoneTasks(int userId);
        List<Task> GetUserNotDoneTasks(int userId);
        Task GetUserTaskById(int taskId);
        void AddNewTask(Task task);
        int GetTaskCount(int userId);
        List<SubTask> GetAllUserSubTasks(int userId);
        void AddNewSubTask(SubTask task);
    }
}
