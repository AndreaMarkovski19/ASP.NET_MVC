using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.Domain.Enums;

namespace ToDoApp.Domain.Models
{
    public class SubTask
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
    }
}
