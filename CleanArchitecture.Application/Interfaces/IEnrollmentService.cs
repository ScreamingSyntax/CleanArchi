using CleanArchitecture.Application.DTOs;

namespace CleanArchitecture.Application.Interfaces;

public interface IEnrollmentService
{
    Task<IEnumerable<EnrollmentDto>> GetAllAsync();
    Task<IEnumerable<EnrollmentDto>> GetByStudentIdAsync(int studentId);
    Task<IEnumerable<EnrollmentDto>> GetByCourseIdAsync(int courseId);
    Task<EnrollmentDto> CreateAsync(CreateEnrollmentDto dto);
    Task<bool> DeleteAsync(int studentId, int courseId);
}
