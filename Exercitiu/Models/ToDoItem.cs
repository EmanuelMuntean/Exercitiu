namespace Exercitiu.Models
{
    public class ToDoItem
    {
    }
}
public class TodoItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Deadline { get; set; }
    public int Status { get; set; } // 0 = Pending, 1 = Done, 2 = Rejected
}
