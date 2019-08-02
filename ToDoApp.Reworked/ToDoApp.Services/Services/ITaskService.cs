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
        List<SubTask> GetAllSubTasks();

        Task GetTaskById(int id);
        SubTask GetSubTaskById(int id);

        void CreateNewTask(Task task);        
        void CreateNewSubTask(SubTask subTask);

        void UpdateTask(Task task);
    }
}
