using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Models.DomainModels;

namespace ToDoApp.Models.ViewModels
{
    public class InProgressTasksViewModel
    {
        public List<Tasks> InProgress { get; set; } = new List<Tasks>();
    }
}
