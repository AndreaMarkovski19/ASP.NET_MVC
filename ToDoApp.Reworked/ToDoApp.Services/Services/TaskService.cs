using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.DataAccess.Repositories;
using ToDoApp.Domain.Models;
using Task = ToDoApp.Domain.Models.Task;

namespace ToDoApp.Services.Services
{
    public class TaskService : ITaskService
    {
        private IRepository<Task> _taskRepository;
        private IRepository<SubTask> _subTaskRepository;

        public TaskService(IRepository<Task> taskRepository, IRepository<SubTask> subTaskRepository)
        {
            _taskRepository = taskRepository;
            _subTaskRepository = subTaskRepository;
        }

        public void CreateNewTask(Task task)
        {
            _taskRepository.Insert(task);
        }

        public List<Task> GetAllTasks()
        {
            return _taskRepository.GetAll();
        }

        public Task GetTaskById(int id)
        {
            return _taskRepository.GetById(id);
        }
                
        public List<SubTask> GetAllSubTasks()
        {
            return _subTaskRepository.GetAll();
        }

        public SubTask GetSubTaskById(int id)
        {
            return _subTaskRepository.GetById(id);
        }

        public void CreateNewSubTask(SubTask subTask)
        {
            _subTaskRepository.Insert(subTask);
        }

        public void UpdateTask(Task task)
        {
            _taskRepository.Update(task);
        }
    }
}
