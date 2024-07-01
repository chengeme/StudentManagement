using Microsoft.EntityFrameworkCore;
using StudentManagement.Infrastructure.Configuration;
using StudentManagement.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Infrastructure.Context
{
    public class WalletContext : DbContext
    {
        public WalletContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StudentConfig).Assembly);//apply config co trong file
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CourseConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EnrollmentConfig).Assembly);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
    }
}
