using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Infrastructure.Data;

namespace CleanArchitecture.Infrastructure.Repositories;

public class StudentRepository(AppDbContext context)
    : RepositoryBase<Student>(context), IStudentRepository
{
}
