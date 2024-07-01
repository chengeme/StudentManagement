using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Infrastructure.Entities;

namespace StudentManagement.Domain.Services.Interface
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAllStudents();
        Task<Student> GetStudentById(int id);
        Task AddStudent(Student student);
        Task UpdateStudent(Student student);
        Task DeleteStudent(int id);
    }
}
