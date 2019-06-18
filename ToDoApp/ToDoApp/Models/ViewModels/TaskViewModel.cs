using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Models.DomainModels;
using ToDoApp.Models.DomainModels.Enums;
using Type = ToDoApp.Models.DomainModels.Enums.Type;

namespace ToDoApp.Models.ViewModels
{
    public class TaskViewModel
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Title of the Task")]
        public string Title { get; set; }
        [Display(Name = "Description of the Task")]
        public string Description { get; set; }
        [Display(Name = "Priority of the Task")]
        public Priority Priority { get; set; }
        [Display(Name = "Status of the Task")]
        public Status Status { get; set; }
        [Display(Name = "Type of the Task")]
        public Type Type { get; set; }
    }
}
