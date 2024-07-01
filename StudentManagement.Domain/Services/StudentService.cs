using StudentManagement.Domain.Services.Interface;
using StudentManagement.Infrastructure.Context;
using StudentManagement.Infrastructure.Entities;
using StudentManagement.Infrastructure.Repositories.StudentRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Domain.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            return await _studentRepository.GetAll();
        }

        public async Task<Student> GetStudentById(int id)
        {
            return await _studentRepository.GetById(id);
        }

        public async Task AddStudent(Student student)
        {
            await _studentRepository.Add(student);
        }

        public async Task UpdateStudent(Student student)
        {
            await _studentRepository.Update(student);
        }

        public async Task DeleteStudent(int id)
        {
            await _studentRepository.Delete(id);
        }
    }
}
