using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Models.DomainModels;

namespace ToDoApp.Models.ViewModels
{
    public class DoneTasksViewModel
    {        
        public List<Tasks> Done { get; set; } = new List<Tasks>();
    }
}
