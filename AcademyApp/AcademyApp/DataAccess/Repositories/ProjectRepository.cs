using AcademyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyApp.DataAccess.Repositories
{
    public class ProjectRepository : IRepository<Project>
    {
        private AcademyDbContext _context;
        public ProjectRepository(AcademyDbContext context)
        {
            _context = context;
        }

        public void DeleteById(int id)
        {
            Project project = _context.Projects.SingleOrDefault(x => x.Id == id);
            if (project != null) _context.Projects.Remove(project);
            _context.SaveChanges();
        }

        public List<Project> GetAll()
        {
            return _context.Projects.ToList();
        }

        public Project GetById(int id)
        {
            return _context.Projects.SingleOrDefault(x => x.Id == id);
        }

        public int Insert(Project entity)
        {
            _context.Projects.Add(entity);
            int id = _context.SaveChanges();
            return id;
        }

        public void Update(Project entity)
        {
            Project project = _context.Projects.SingleOrDefault(x => x.Id == entity.Id);
            if (project != null)
            {
                _context.Projects.Update(project);
                _context.SaveChanges();
            }
        }
    }
}
