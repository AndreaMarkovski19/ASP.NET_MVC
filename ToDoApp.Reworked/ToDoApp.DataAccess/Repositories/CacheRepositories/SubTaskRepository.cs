using System;
using System.Collections.Generic;
using ToDoApp.Domain.Models;
using System.Linq;

namespace ToDoApp.DataAccess.Repositories.CacheRepositories
{
    public class SubTaskRepository : IRepository<SubTask>
    {
        public int Insert(SubTask entity)
        {
            CacheDb.SubTaskId++;
            entity.Id = CacheDb.SubTaskId;
            CacheDb.SubTasks.Add(entity);

            return entity.Id;
        }

        public void DeleteById(int id)
        {
            SubTask subTask = CacheDb.SubTasks.FirstOrDefault(x => x.Id == id);
            if (subTask != null)
            {
                CacheDb.SubTasks.Remove(subTask);
            }
        }

        public List<SubTask> GetAll()
        {
            return CacheDb.SubTasks;
        }

        public SubTask GetById(int id)
        {
            return CacheDb.SubTasks.FirstOrDefault(x => x.Id == id);
        }

        public void Update(SubTask entity)
        {
            SubTask subTask = CacheDb.SubTasks.FirstOrDefault(x => x.Id == entity.Id);
            if (subTask != null)
            {
                int index = CacheDb.SubTasks.IndexOf(subTask);
                CacheDb.SubTasks[index] = entity;
            }
        }
    }
}
