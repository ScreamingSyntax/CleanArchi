using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CleanArchitecture.Domain.Enums;

namespace CleanArchitecture.Domain.Entities;

public class StudentCourse
{
    [Key, Column(Order = 0)]
    [ForeignKey(nameof(Student))]
    public int StudentId { get; set; }
    public Student Student { get; set; } = null!;

    [Key, Column(Order = 1)]
    [ForeignKey(nameof(Course))]
    public int CourseId { get; set; }
    public Course Course { get; set; } = null!;

    [Required]
    public DateTime EnrollmentDate { get; set; }

    public EnrollmentStatus Status { get; set; } = EnrollmentStatus.Enrolled;
}
