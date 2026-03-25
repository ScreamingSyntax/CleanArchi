using CleanArchitecture.Application.DTOs;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Services;

public class StudentService(IStudentRepository repository) : IStudentService
{
    public async Task<IEnumerable<StudentDto>> GetAllAsync()
    {
        var students = await repository.FindAllAsync();
        return students.Select(s => new StudentDto(s.StudentId, s.Name, s.Email, s.Status));
    }

    public async Task<StudentDto?> GetByIdAsync(int id)
    {
        var student = await repository.GetByIdAsync(id);
        return student is null ? null : new StudentDto(student.StudentId, student.Name, student.Email, student.Status);
    }

    public async Task<StudentDto> CreateAsync(CreateStudentDto dto)
    {
        var student = new Student
        {
            Name = dto.Name,
            Email = dto.Email,
            Status = dto.Status
        };

        repository.Create(student);
        await repository.SaveChangesAsync();

        return new StudentDto(student.StudentId, student.Name, student.Email, student.Status);
    }

    public async Task<StudentDto?> UpdateAsync(int id, UpdateStudentDto dto)
    {
        var student = await repository.GetByIdAsync(id);
        if (student is null) return null;

        student.Name = dto.Name;
        student.Email = dto.Email;
        student.Status = dto.Status;

        repository.Update(student);
        await repository.SaveChangesAsync();

        return new StudentDto(student.StudentId, student.Name, student.Email, student.Status);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var student = await repository.GetByIdAsync(id);
        if (student is null) return false;

        repository.Delete(student);
        await repository.SaveChangesAsync();
        return true;
    }
}
