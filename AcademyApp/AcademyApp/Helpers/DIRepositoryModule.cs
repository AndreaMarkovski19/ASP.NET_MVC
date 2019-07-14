using AcademyApp.DataAccess;
using AcademyApp.DataAccess.Repositories;
using AcademyApp.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyApp.Helpers
{
    public static class DIRepositoryModule
    {
        public static IServiceCollection RegisterRepositories(IServiceCollection services)
        {
            services.AddTransient<IRepository<Student>, StudentRepository>();
            services.AddTransient<IRepository<Project>, ProjectRepository>();

            return services;
        }
    }
}
