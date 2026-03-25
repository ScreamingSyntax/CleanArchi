using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Infrastructure.Data;

namespace CleanArchitecture.Infrastructure.Repositories;

public class CourseRepository(AppDbContext context)
    : RepositoryBase<Course>(context), ICourseRepository
{
}
