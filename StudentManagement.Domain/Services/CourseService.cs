using StudentManagement.Domain.Services.Interface;
using StudentManagement.Infrastructure.Entities;
using StudentManagement.Infrastructure.Repositories.CourseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Domain.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task<IEnumerable<Course>> GetAllCourses()
        {
            return await _courseRepository.GetAll();
        }

        public async Task<Course> GetCourseById(int id)
        {
            return await _courseRepository.GetById(id);
        }

        public async Task AddCourse(Course course)
        {
            await _courseRepository.Add(course);
        }

        public async Task UpdateCourse(Course course)
        {
            await _courseRepository.Update(course);
        }

        public async Task DeleteCourse(int id)
        {
            await _courseRepository.Delete(id);
        }
    }
}
