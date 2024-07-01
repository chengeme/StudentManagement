using StudentManagement.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Domain.Services.Interface
{
    public interface IEnrollmentService
    {
        Task<IEnumerable<Enrollment>> GetAllEnrollments();
        Task<Enrollment> GetEnrollmentById(int id);
        Task AddEnrollment(Enrollment enrollment);
        Task UpdateEnrollment(Enrollment enrollment);
        Task DeleteEnrollment(int id);
    }
}
