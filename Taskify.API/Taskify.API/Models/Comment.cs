namespace Taskify.API.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public string? Content { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
