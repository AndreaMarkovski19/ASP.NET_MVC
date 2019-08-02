using AcademyApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyApp.DataAccess
{
    public partial class AcademyDbContext : DbContext
    {
        public AcademyDbContext(DbContextOptions<AcademyDbContext> options)
            : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // CONFIGURATIONS
            modelBuilder.Entity<Student>()
                .HasMany(x => x.Projects)
                .WithOne(x => x.Student)
                .HasForeignKey(x => x.StudentId);

            // SEEDING
            modelBuilder.Entity<Student>()
                .HasData(
                new Student()
                {
                    Id = 1,
                    FirstName = "Andrea",
                    LastName = "Markovski",
                    Age = 35,
                    Academy = Academy.Code
                },
                new Student()
                {
                    Id = 2,
                    FirstName = "Martin",
                    LastName = "Vitanov",
                    Age = 22,
                    Academy = Academy.Network
                });

            modelBuilder.Entity<Project>()
                .HasData(
                new Project()
                {
                    Id = 1,
                    StudentId = 1,
                    Title = "Project_01",
                    EstimatedTime = 10,
                    TimeSpent = 20
                },
               new Project()
               {
                   Id = 2,
                   StudentId = 1,
                   Title = "Project_02",
                   EstimatedTime = 8,
                   TimeSpent = 4
               },
               new Project()
               {
                   Id = 3,
                   StudentId = 1,
                   Title = "Project_03",
                   EstimatedTime = 4,
                   TimeSpent = 3
               },
               new Project()
               {
                   Id = 4,
                   StudentId = 2,
                   Title = "Project_04",
                   EstimatedTime = 4,
                   TimeSpent = 3
               },
               new Project()
               {
                   Id = 5,
                   StudentId = 2,
                   Title = "Project_05",
                   EstimatedTime = 7,
                   TimeSpent = 3
               },
               new Project()
               {
                   Id = 6,
                   StudentId = 2,
                   Title = "Project_06",
                   EstimatedTime = 54,
                   TimeSpent = 12
               });
        }
    }
}
