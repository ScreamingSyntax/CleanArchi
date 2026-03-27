using CleanArchitecture.Domain.Enums;

namespace CleanArchitecture.Application.DTOs;

public class StudentDto
{
    public int StudentId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public StudentStatus Status { get; set; }
}

public class CreateStudentDto
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public StudentStatus Status { get; set; } = StudentStatus.Active;
}

public class UpdateStudentDto
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public StudentStatus Status { get; set; }
}
