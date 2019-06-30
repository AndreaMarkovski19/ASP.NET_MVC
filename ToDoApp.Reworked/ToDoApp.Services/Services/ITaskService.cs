using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Domain.Models;
using Task = ToDoApp.Domain.Models.Task;

namespace ToDoApp.Services.Services
{
    public interface ITaskService
    {
        List<Task> GetAllTasks();
        Task GetTaskById(int id);
        int GetTaskCount();
        void CreateNewTask(Task task);
        List<SubTask> GetAllSubTasks();
        SubTask GetSubTaskById(int id);
        void CreateNewSubTask(SubTask subTask);
    }
}
