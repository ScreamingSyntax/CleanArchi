using CleanArchitecture.Application.DTOs;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Services;

public class EnrollmentService(IEnrollmentRepository repository) : IEnrollmentService
{
    public async Task<IEnumerable<EnrollmentDto>> GetAllAsync()
    {
        var enrollments = await repository.FindAllAsync();
        return enrollments.Select(MapToDto);
    }

    public async Task<IEnumerable<EnrollmentDto>> GetByStudentIdAsync(int studentId)
    {
        var enrollments = await repository.GetByStudentIdAsync(studentId);
        return enrollments.Select(MapToDto);
    }

    public async Task<IEnumerable<EnrollmentDto>> GetByCourseIdAsync(int courseId)
    {
        var enrollments = await repository.GetByCourseIdAsync(courseId);
        return enrollments.Select(MapToDto);
    }

    public async Task<EnrollmentDto> CreateAsync(CreateEnrollmentDto dto)
    {
        var enrollment = new StudentCourse
        {
            StudentId = dto.StudentId,
            CourseId = dto.CourseId,
            EnrollmentDate = dto.EnrollmentDate,
            Status = dto.Status
        };

        repository.Create(enrollment);
        await repository.SaveChangesAsync();

        var created = await repository.GetByIdAsync(dto.StudentId, dto.CourseId);
        return MapToDto(created!);
    }

    public async Task<bool> DeleteAsync(int studentId, int courseId)
    {
        var enrollment = await repository.GetByIdAsync(studentId, courseId);
        if (enrollment is null) return false;

        repository.Delete(enrollment);
        await repository.SaveChangesAsync();
        return true;
    }

    private static EnrollmentDto MapToDto(StudentCourse sc) => new()
    {
        StudentId = sc.StudentId,
        StudentName = sc.Student.Name,
        CourseId = sc.CourseId,
        CourseName = sc.Course.CourseName,
        EnrollmentDate = sc.EnrollmentDate,
        Status = sc.Status
    };
}
