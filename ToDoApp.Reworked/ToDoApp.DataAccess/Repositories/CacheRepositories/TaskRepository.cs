using System;
using System.Collections.Generic;
using ToDoApp.Domain.Models;
using System.Linq;

namespace ToDoApp.DataAccess.Repositories.CacheRepositories
{
    public class TaskRepository : IRepository<Task>
    {
        public void DeleteById(int id)
        {
            Task task = CacheDb.Tasks.FirstOrDefault(x => x.Id == id);

            if (task != null) CacheDb.Tasks.Remove(task);
        }

        public List<Task> GetAll()
        {
            return CacheDb.Tasks;
        }

        public Task GetById(int id)
        {
            return CacheDb.Tasks.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Task entity)
        {
            CacheDb.TaskId++;
            entity.Id = CacheDb.TaskId;
            CacheDb.Tasks.Add(entity);
            return entity.Id;
        }

        public void Update(Task entity)
        {
            Task task = CacheDb.Tasks.FirstOrDefault(x => x.Id == entity.Id);
            if (task != null)
            {
                int index = CacheDb.Tasks.IndexOf(task);
                CacheDb.Tasks[index] = entity;
            }
        }
    }
}
