using System;

namespace SmartTaskPlanner.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public string Category { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
    }
}
