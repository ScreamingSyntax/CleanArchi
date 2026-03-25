using CleanArchitecture.Application.DTOs;
using CleanArchitecture.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EnrollmentsController(IEnrollmentService enrollmentService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var enrollments = await enrollmentService.GetAllAsync();
        return Ok(enrollments);
    }

    [HttpGet("student/{studentId}")]
    public async Task<IActionResult> GetByStudent(int studentId)
    {
        var enrollments = await enrollmentService.GetByStudentIdAsync(studentId);
        return Ok(enrollments);
    }

    [HttpGet("course/{courseId}")]
    public async Task<IActionResult> GetByCourse(int courseId)
    {
        var enrollments = await enrollmentService.GetByCourseIdAsync(courseId);
        return Ok(enrollments);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateEnrollmentDto dto)
    {
        var enrollment = await enrollmentService.CreateAsync(dto);
        return Created(string.Empty, enrollment);
    }

    [HttpDelete("{studentId}/{courseId}")]
    public async Task<IActionResult> Delete(int studentId, int courseId)
    {
        var result = await enrollmentService.DeleteAsync(studentId, courseId);
        return result ? NoContent() : NotFound();
    }
}
