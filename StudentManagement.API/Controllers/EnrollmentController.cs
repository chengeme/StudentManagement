using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Domain.Services.Interface;
using StudentManagement.Infrastructure.Entities;

namespace StudentManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollmentController : ControllerBase
    {
        private readonly IEnrollmentService _enrollmentService;

        public EnrollmentController(IEnrollmentService enrollmentService)
        {
            _enrollmentService = enrollmentService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Enrollment>>> GetEnrollments()
        {
            var enrollments = await _enrollmentService.GetAllEnrollments();
            return Ok(enrollments);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Enrollment>> GetEnrollment(int id)
        {
            var enrollment = await _enrollmentService.GetEnrollmentById(id);
            if (enrollment == null)
            {
                return NotFound();
            }
            return Ok(enrollment);
        }

        [HttpPost]
        public async Task<ActionResult> AddEnrollment(Enrollment enrollment)
        {
            await _enrollmentService.AddEnrollment(enrollment);
            return CreatedAtAction(nameof(GetEnrollment), new { id = enrollment.Id }, enrollment);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEnrollment(int id, Enrollment enrollment)
        {
            if (id != enrollment.Id)
            {
                return BadRequest();
            }

            await _enrollmentService.UpdateEnrollment(enrollment);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEnrollment(int id)
        {
            await _enrollmentService.DeleteEnrollment(id);
            return NoContent();
        }
    }
}
