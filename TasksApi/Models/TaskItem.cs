namespace TasksApi.Models;

public class TaskItem
{
    public long Id { get; set; }
    public string? TaskName { get; set; }
    public string? TaskType { get; set; }
    public string? TaskLanguage { get; set; }
    public bool IsComplete { get; set; }
}