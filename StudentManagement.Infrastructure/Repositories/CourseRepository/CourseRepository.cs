using Microsoft.EntityFrameworkCore;
using StudentManagement.Infrastructure.Context;
using StudentManagement.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Infrastructure.Repositories.CourseRepository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly WalletContext _context;

        public CourseRepository(WalletContext context)
        {
            _context = context;
        }

        public async Task Add(Course course)
        {
            await _context.Courses.AddAsync(course);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var course = await GetById(id);
            if (course != null)
            {
                _context.Courses.Remove(course);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Course>> GetAll()
        {
            return await _context.Courses.ToListAsync();
        }

        public async Task<Course> GetById(int id)
        {
            return await _context.Courses.FindAsync(id);
        }

        public async Task Update(Course course)
        {
            _context.Courses.Update(course);
            await _context.SaveChangesAsync();
        }
    }
}
