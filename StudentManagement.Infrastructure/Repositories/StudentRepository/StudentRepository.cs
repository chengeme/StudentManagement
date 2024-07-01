using Microsoft.EntityFrameworkCore;
using StudentManagement.Infrastructure.Context;
using StudentManagement.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Infrastructure.Repositories.StudentRepository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly WalletContext _context;

        public StudentRepository(WalletContext context)
        {
            _context = context;
        }

        public async Task Add(Student student)
        {
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var student = await GetById(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Student> GetById(int id)
        {
            return await _context.Students.FindAsync(id);
        }

        public async Task Update(Student student)
        {
            _context.Students.Update(student);
            await _context.SaveChangesAsync();
        }
    }
}
