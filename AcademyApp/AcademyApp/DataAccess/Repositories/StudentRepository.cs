using AcademyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyApp.DataAccess.Repositories
{
    public class StudentRepository : IRepository<Student>
    {
        private AcademyDbContext _context;
        public StudentRepository(AcademyDbContext context)
        {
            _context = context;
        }

        public void DeleteById(int id)
        {
            Student student = _context.Students.SingleOrDefault(x => x.Id == id);
            if (student != null) _context.Students.Remove(student);
            _context.SaveChanges();
        }

        public List<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public Student GetById(int id)
        {
            return _context.Students.SingleOrDefault(x => x.Id == id);
        }

        public int Insert(Student entity)
        {
            _context.Students.Add(entity);
            int id = _context.SaveChanges();
            return id;
        }

        public void Update(Student entity)
        {
            Student student = _context.Students.SingleOrDefault(x => x.Id == entity.Id);
            if (student != null)
            {
                _context.Students.Update(entity);
                _context.SaveChanges();
            }
        }
    }
}
