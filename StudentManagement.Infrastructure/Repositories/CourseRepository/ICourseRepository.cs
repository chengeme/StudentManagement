using StudentManagement.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Infrastructure.Repositories.CourseRepository
{
    public interface ICourseRepository
    {
        Task<IEnumerable<Course>> GetAll();
        Task<Course> GetById(int id);
        Task Add(Course course);
        Task Update(Course course);
        Task Delete(int id);
    }
}
