using StudentManagement.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Infrastructure.Repositories.EnrollmentRepository
{
    public interface IEnrollmentRepository
    {
        Task<IEnumerable<Enrollment>> GetAll();
        Task<Enrollment> GetById(int id);
        Task Add(Enrollment enrollment);
        Task Update(Enrollment enrollment);
        Task Delete(int id);
    }
}
