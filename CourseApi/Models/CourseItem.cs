namespace CourseApi.Models;

public class CourseItem
{
    public long Id { get; set; }
    public string? CourseName { get; set; }
    public string? CourseDuration { get; set; }
    public string? CourseLanguage { get; set; }
    public bool IsComplete { get; set; }
}