namespace todo_list_api.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public List<string>? SubTask { get; set; }
        public string? DueDate { get; set; }
        public string? Reminder { get; set; }
        public string? Repeat { get; set; }
        public string? Category { get; set; }
        public List<string>? File { get; set; }
        public string? Note { get; set; }
        public bool Completed { get; set; }
        public bool Favourite { get; set; }
    }
}
