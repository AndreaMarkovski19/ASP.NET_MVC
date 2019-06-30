using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.WebApp.Models
{
    public class InProgressTasksViewModel
    {
        public List<TaskViewModel> InProgress { get; set; } = new List<TaskViewModel>();
    }
}
