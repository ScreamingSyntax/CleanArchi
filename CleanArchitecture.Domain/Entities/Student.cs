using System.ComponentModel.DataAnnotations;
using CleanArchitecture.Domain.Enums;

namespace CleanArchitecture.Domain.Entities;

public class Student
{
    [Key]
    public int StudentId { get; set; }

    [Required]
    [MaxLength(200)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [MaxLength(200)]
    public string Email { get; set; } = string.Empty;

    public StudentStatus Status { get; set; } = StudentStatus.Active;

    public ICollection<StudentCourse> StudentCourses { get; set; } = [];
}
