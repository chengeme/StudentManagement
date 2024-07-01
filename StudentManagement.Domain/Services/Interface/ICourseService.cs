using StudentManagement.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Domain.Services.Interface
{
    public interface ICourseService
    {
        Task<IEnumerable<Course>> GetAllCourses();
        Task<Course> GetCourseById(int id);
        Task AddCourse(Course course);
        Task UpdateCourse(Course course);
        Task DeleteCourse(int id);
    }
}
