namespace Taskify.API.Models
{
    public class TaskItem
    {
        public int ID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int ProjectId { get; set; }
        public enum Status
        {
            Todo,
            InProgress,
            Testing,
            Done
        }
        public enum Priority
        {
            Low,
            Medium,
            High
        }
    }
}
