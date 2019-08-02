using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.Domain.Enums;
using ToDoApp.Domain.Models;
using Type = ToDoApp.Domain.Enums.Type;

namespace ToDoApp.DataAccess
{
    public partial class ToDoDbContext : DbContext
    {
        public ToDoDbContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<SubTask> SubTasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // CONFIGURATIONS
            modelBuilder.Entity<User>()
                .HasMany(x => x.ToDoTasks)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);

            modelBuilder.Entity<Task>()
                .HasMany(x => x.SubTasks)
                .WithOne(x => x.Task)
                .HasForeignKey(x => x.TaskId);

            // SEEDING
            modelBuilder.Entity<User>()
                .HasData(
                new User()
                {
                    Id = 1,
                    FirstName = "Andrea",
                    LastName = "Markovski",
                    Age = 35,
                    AverageFreeTime = 10,
                });

            modelBuilder.Entity<Task>()
                .HasData(
               new Task()
               {
                   Id = 1,
                   UserId = 1,
                   Title = "Homework01",
                   Description = "MVC",
                   Priority = Priority.Important,
                   Status = Status.NotDone,
                   Type = Type.Work,
               },
               new Task()
               {
                   Id = 2,
                   UserId = 1,
                   Title = "Homework02",
                   Description = "MVC",
                   Priority = Priority.Important,
                   Status = Status.NotDone,
                   Type = Type.Work,
               },
               new Task()
               {
                   Id = 3,
                   UserId = 1,
                   Title = "Homework03",
                   Description = "MVC",
                   Priority = Priority.Important,
                   Status = Status.NotDone,
                   Type = Type.Work
               },
               new Task()
               {
                   Id = 4,
                   UserId = 1,
                   Title = "Homework04",
                   Description = "MVC",
                   Priority = Priority.Important,
                   Status = Status.Done,
                   Type = Type.Work
               },
               new Task()
               {
                   Id = 5,
                   UserId = 1,
                   Title = "Homework05",
                   Description = "MVC",
                   Priority = Priority.Important,
                   Status = Status.Done,
                   Type = Type.Work
               },
               new Task()
               {
                   Id = 6,
                   UserId = 1,
                   Title = "Homework06",
                   Description = "MVC",
                   Priority = Priority.Important,
                   Status = Status.InProgress,
                   Type = Type.Work
               },
               new Task()
               {
                   Id = 7,
                   UserId = 1,
                   Title = "Homework07",
                   Description = "MVC",
                   Priority = Priority.Important,
                   Status = Status.InProgress,
                   Type = Type.Work
               });

            modelBuilder.Entity<SubTask>()
                .HasData(
                new SubTask()
                {
                    Id = 1,
                    TaskId = 1,
                    Title = "Subtask01",
                    Description = "MVC",
                    SubStatus = SubStatus.NotDone,
                },
                new SubTask()
                {
                    Id = 2,
                    TaskId = 1,
                    Title = "Subtask02",
                    Description = "MVC",
                    SubStatus = SubStatus.Done,
                },
                new SubTask()
                {
                    Id = 3,
                    TaskId = 2,
                    Title = "Subtask03",
                    Description = "MVC",
                    SubStatus = SubStatus.NotDone,
                },
                new SubTask()
                {
                    Id = 4,
                    TaskId = 2,
                    Title = "Subtask04",
                    Description = "MVC",
                    SubStatus = SubStatus.Done,
                },
                new SubTask()
                {
                    Id = 5,
                    TaskId = 3,
                    Title = "Subtask05",
                    Description = "MVC",
                    SubStatus = SubStatus.NotDone,
                },
                new SubTask()
                {
                    Id = 6,
                    TaskId = 3,
                    Title = "Subtask06",
                    Description = "MVC",
                    SubStatus = SubStatus.Done,
                });
        }
    }
}
