using CleanArchitecture.Domain.Enums;

namespace CleanArchitecture.Application.DTOs;

public record StudentDto(int StudentId, string Name, string Email, StudentStatus Status);

public record CreateStudentDto(string Name, string Email, StudentStatus Status = StudentStatus.Active);

public record UpdateStudentDto(string Name, string Email, StudentStatus Status);
