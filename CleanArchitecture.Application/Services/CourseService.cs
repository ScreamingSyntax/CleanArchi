using CleanArchitecture.Application.DTOs;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Services;

public class CourseService(ICourseRepository repository) : ICourseService
{
    public async Task<IEnumerable<CourseDto>> GetAllAsync()
    {
        var courses = await repository.FindAllAsync();
        return courses.Select(c => new CourseDto(c.CourseId, c.CourseName, c.Credits, c.Level));
    }

    public async Task<CourseDto?> GetByIdAsync(int id)
    {
        var course = await repository.GetByIdAsync(id);
        return course is null ? null : new CourseDto(course.CourseId, course.CourseName, course.Credits, course.Level);
    }

    public async Task<CourseDto> CreateAsync(CreateCourseDto dto)
    {
        var course = new Course
        {
            CourseName = dto.CourseName,
            Credits = dto.Credits,
            Level = dto.Level
        };

        repository.Create(course);
        await repository.SaveChangesAsync();

        return new CourseDto(course.CourseId, course.CourseName, course.Credits, course.Level);
    }

    public async Task<CourseDto?> UpdateAsync(int id, UpdateCourseDto dto)
    {
        var course = await repository.GetByIdAsync(id);
        if (course is null) return null;

        course.CourseName = dto.CourseName;
        course.Credits = dto.Credits;
        course.Level = dto.Level;

        repository.Update(course);
        await repository.SaveChangesAsync();

        return new CourseDto(course.CourseId, course.CourseName, course.Credits, course.Level);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var course = await repository.GetByIdAsync(id);
        if (course is null) return false;

        repository.Delete(course);
        await repository.SaveChangesAsync();
        return true;
    }
}
