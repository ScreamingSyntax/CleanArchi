using CleanArchitecture.Domain.Enums;

namespace CleanArchitecture.Application.DTOs;

public record EnrollmentDto(int StudentId, string StudentName, int CourseId, string CourseName, DateTime EnrollmentDate, EnrollmentStatus Status);

public record CreateEnrollmentDto(int StudentId, int CourseId, DateTime EnrollmentDate, EnrollmentStatus Status = EnrollmentStatus.Enrolled);
