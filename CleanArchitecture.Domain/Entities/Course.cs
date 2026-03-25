using System.ComponentModel.DataAnnotations;
using CleanArchitecture.Domain.Enums;

namespace CleanArchitecture.Domain.Entities;

public class Course
{
    [Key]
    public int CourseId { get; set; }

    [Required]
    [MaxLength(200)]
    public string CourseName { get; set; } = string.Empty;

    [Required]
    public int Credits { get; set; }

    public CourseLevel Level { get; set; } = CourseLevel.Beginner;

    public ICollection<StudentCourse> StudentCourses { get; set; } = [];
}
