namespace todo_list_api.Models
{
    public class ListModel
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? GroupId { get; set; }
        public string Name { get; set; }
    }
}
