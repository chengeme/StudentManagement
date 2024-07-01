using Microsoft.EntityFrameworkCore;
using StudentManagement.Infrastructure.Context;
using StudentManagement.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Infrastructure.Repositories.EnrollmentRepository
{
    public class EnrollmentRepository : IEnrollmentRepository
    {
        private readonly WalletContext _context;

        public EnrollmentRepository(WalletContext context)
        {
            _context = context;
        }

        public async Task Add(Enrollment enrollment)
        {
            await _context.Enrollments.AddAsync(enrollment);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var enrollment = await GetById(id);
            if (enrollment != null)
            {
                _context.Enrollments.Remove(enrollment);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Enrollment>> GetAll()
        {
            return await _context.Enrollments.ToListAsync();
        }

        public async Task<Enrollment> GetById(int id)
        {
            return await _context.Enrollments.FindAsync(id);
        }

        public async Task Update(Enrollment enrollment)
        {
            _context.Enrollments.Update(enrollment);
            await _context.SaveChangesAsync();
        }
    }
}
