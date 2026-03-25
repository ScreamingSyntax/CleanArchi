using CleanArchitecture.Domain.Enums;

namespace CleanArchitecture.Application.DTOs;

public record CourseDto(int CourseId, string CourseName, int Credits, CourseLevel Level);

public record CreateCourseDto(string CourseName, int Credits, CourseLevel Level = CourseLevel.Beginner);

public record UpdateCourseDto(string CourseName, int Credits, CourseLevel Level);
