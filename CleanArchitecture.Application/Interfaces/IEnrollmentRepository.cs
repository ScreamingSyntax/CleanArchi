using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Interfaces;

public interface IEnrollmentRepository : IRepositoryBase<StudentCourse>
{
    Task<StudentCourse?> GetByIdAsync(int studentId, int courseId);
    Task<IEnumerable<StudentCourse>> GetByStudentIdAsync(int studentId);
    Task<IEnumerable<StudentCourse>> GetByCourseIdAsync(int courseId);
}
