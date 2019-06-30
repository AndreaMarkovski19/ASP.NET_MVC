using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoApp.DataAccess.Repositories;
using ToDoApp.Domain.Enums;
using ToDoApp.Domain.Models;

namespace ToDoApp.Services.Services
{
    public class UserTasksService : IUserTasksService
    {
        IRepository<Task> _userRepository;
        IRepository<Task> _taskRepository;
        IRepository<SubTask> _subTaskRepository;

        public UserTasksService(IRepository<Task> userRepository, IRepository<Task> taskRepository, IRepository<SubTask> subTaskRepository)
        {
            _userRepository = userRepository;
            _taskRepository = taskRepository;
            _subTaskRepository = subTaskRepository;
        }

        public void AddNewSubTask(SubTask subTask)
        {
            _subTaskRepository.Insert(subTask);
        }

        public void AddNewTask(Task task)
        {
            _taskRepository.Insert(task);
        }

        public List<SubTask> GetAllUserSubTasks(int userId)
        {
            List<SubTask> subtasks = new List<SubTask>();
            foreach (var task in _taskRepository.GetAll().Where(c => c.UserId == userId))
            {
                subtasks.AddRange(task.SubTasks);
                foreach (var subTask in _subTaskRepository.GetAll().Where(c => c.TaskId == task.Id))
                {
                    subtasks.Add(subTask);
                }
            }

            return subtasks;
        }

        public List<Task> GetAllUserTasks(int userId)
        {
            return _taskRepository.GetAll().Where(c => c.UserId == userId).ToList();
        }

        public int GetTaskCount(int userId)
        {
            return _taskRepository.GetAll().Count(c => c.UserId == userId);
        }

        public List<Task> GetUserDoneTasks(int userId)
        {
            return _taskRepository.GetAll().Where(c => c.UserId == userId && c.Status == Status.Done).ToList();
        }

        public List<Task> GetUserNotDoneTasks(int userId)
        {
            return _taskRepository.GetAll().Where(c => c.UserId == userId && c.Status == Status.NotDone).ToList();
        }

        public Task GetUserTaskById(int taskId)
        {
            return _taskRepository.GetById(taskId);
        }
    }
}
