using CleanArchitecture.Domain.Enums;

namespace CleanArchitecture.Application.DTOs;

public class CourseDto
{
    public int CourseId { get; set; }
    public string CourseName { get; set; } = string.Empty;
    public int Credits { get; set; }
    public CourseLevel Level { get; set; }
}

public class CreateCourseDto
{
    public string CourseName { get; set; } = string.Empty;
    public int Credits { get; set; }
    public CourseLevel Level { get; set; } = CourseLevel.Beginner;
}

public class UpdateCourseDto
{
    public string CourseName { get; set; } = string.Empty;
    public int Credits { get; set; }
    public CourseLevel Level { get; set; }
}
