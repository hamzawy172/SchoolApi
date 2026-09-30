using Microsoft.EntityFrameworkCore;
using SchoolApi.Data;
using SchoolApi.MappingProfiles;
using SchoolApi.Repos.immpelementation;
using SchoolApi.Repos.Interfaces;
using SchoolApi.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<MyContext>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("Conn")));
builder.Services.AddScoped(typeof(IGenericRepo<>), typeof(GenericRepo<>));

// Custom Repositories
builder.Services.AddScoped<IStudentRepo, StudentRepo>();
builder.Services.AddScoped<ITeacherRepo, TeacherRepo>();
builder.Services.AddScoped<ISubjectRepo, SubjectRepo>();
builder.Services.AddScoped<IDepartmentRepo, DepartmentRepo>();
builder.Services.AddScoped<IClassRoomRepo, ClassRoomRepo>();
builder.Services.AddScoped<IEnrollmentRepo, EnrollmentRepo>();

// Unit Of Work
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddControllers();

builder.Services.AddAutoMapper(typeof(MappingProfile));

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
