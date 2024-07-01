using Microsoft.EntityFrameworkCore;
using StudentManagement.Domain.Services;
using StudentManagement.Domain.Services.Interface;
using StudentManagement.Infrastructure.Context;
using StudentManagement.Infrastructure.Repositories.CourseRepository;
using StudentManagement.Infrastructure.Repositories.EnrollmentRepository;
using StudentManagement.Infrastructure.Repositories.StudentRepository;

var builder = WebApplication.CreateBuilder(args);

var connection = builder.Configuration.GetConnectionString("WalletConnection"); //connect db

builder.Services.AddDbContext<WalletContext>(x => x.UseMySql(connection, ServerVersion.Parse("8.4.0-mysql")));
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<ICourseRepository, CourseRepository>();
builder.Services.AddScoped<IEnrollmentRepository, EnrollmentRepository>();

builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<ICourseService, CourseService>();
builder.Services.AddScoped<IEnrollmentService, EnrollmentService>();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
