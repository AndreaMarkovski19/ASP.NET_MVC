using ToDoApp.Models.DomainModels.Enums;

namespace ToDoApp.Models.DomainModels
{
    public class SubTasks
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
    }
}