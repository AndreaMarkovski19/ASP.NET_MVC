using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyApp.Models
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Academy Academy { get; set; }        
        public List<ProjectViewModel> Projects { get; set; } = new List<ProjectViewModel>();
    }
}
