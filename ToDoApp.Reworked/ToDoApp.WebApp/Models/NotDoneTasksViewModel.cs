using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ToDoApp.WebApp.Models
{
    public class NotDoneTasksViewModel
    {        
        public List<TaskViewModel> NotDone { get; set; } = new List<TaskViewModel>();
    }
}
