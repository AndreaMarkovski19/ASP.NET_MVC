using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.DataAccess.Repositories;
using ToDoApp.DataAccess.Repositories.CacheRepositories;
using ToDoApp.Domain;
using ToDoApp.Domain.Models;
using Task = ToDoApp.Domain.Models.Task;

namespace ToDoApp.Services.Helpers
{
    public static class DIRepositoryModule
    {
        public static IServiceCollection RegisterRepositories(IServiceCollection services)
        {
            services.AddTransient<IRepository<User>, UserRepository>();
            services.AddTransient<IRepository<Task>, TaskRepository>();
            services.AddTransient<IRepository<SubTask>, SubTaskRepository>();

            return services;
        }
    }
}
