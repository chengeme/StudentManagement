using StudentManagement.Domain.Services.Interface;
using StudentManagement.Infrastructure.Entities;
using StudentManagement.Infrastructure.Repositories.EnrollmentRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Domain.Services
{
    public class EnrollmentService : IEnrollmentService
    {
        private readonly IEnrollmentRepository _enrollmentRepository;

        public EnrollmentService(IEnrollmentRepository enrollmentRepository)
        {
            _enrollmentRepository = enrollmentRepository;
        }

        public async Task<IEnumerable<Enrollment>> GetAllEnrollments()
        {
            return await _enrollmentRepository.GetAll();
        }

        public async Task<Enrollment> GetEnrollmentById(int id)
        {
            return await _enrollmentRepository.GetById(id);
        }

        public async Task AddEnrollment(Enrollment enrollment)
        {
            await _enrollmentRepository.Add(enrollment);
        }

        public async Task UpdateEnrollment(Enrollment enrollment)
        {
            await _enrollmentRepository.Update(enrollment);
        }

        public async Task DeleteEnrollment(int id)
        {
            await _enrollmentRepository.Delete(id);
        }
    }
}
