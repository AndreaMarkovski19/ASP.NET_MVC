using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Domain.Models;

namespace ToDoApp.WebApp.Models
{
    public class DoneTasksViewModel
    {
        public List<TaskViewModel> Done { get; set; } = new List<TaskViewModel>();        
    }
}
