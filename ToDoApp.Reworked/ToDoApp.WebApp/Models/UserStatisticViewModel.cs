using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.WebApp.Models
{
    public class UserStatisticViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double AverageFreeTime { get; set; }
        public List<TaskViewModel> Tasks { get; set; } = new List<TaskViewModel>();
    }
}
