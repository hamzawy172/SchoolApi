using Microsoft.EntityFrameworkCore;
using SchoolApi.Models;

namespace SchoolApi.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base (options)
        {
        }

        public DbSet<Student> students { get; set; }
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Subject> subjects { get; set; }
        public DbSet<Enrollment> enrollments { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<ClassRoom> classRooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Department>()
                .HasMany(d => d.teachers)
                .WithOne(t => t.Department)
                .HasForeignKey(t => t.DepartmentId);


            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.subjects)
                .WithOne(s => s.Teacher)
                .HasForeignKey(s => s.TeacherId);


            modelBuilder.Entity<ClassRoom>()
                .HasMany(c => c.students)
                .WithOne(s => s.ClassRoom)
                .HasForeignKey(s => s.ClassRoomId);


            modelBuilder.Entity<Student>()
                .HasMany(s => s.enrollments)
                .WithOne(e => e.Student)
                .HasForeignKey(s => s.StudentId);



            modelBuilder.Entity<Subject>()
                .HasMany(s => s.enrollments)
                .WithOne(e => e.Subject)
                .HasForeignKey(s => s.SubjectId);


            modelBuilder.Entity<Student>()
                .HasIndex(s => s.Email)
                .IsUnique();




            modelBuilder.Entity<Enrollment>()
           .HasIndex(e => new { e.StudentId, e.SubjectId })
           .IsUnique();




            modelBuilder.Entity<Department>().HasData(
                new Department
                {
                    DepartmentId = 1,
                    Name = "Computer Science",
                    Description = "Software and programming department"
                },
                new Department
                {
                    DepartmentId = 2,
                    Name = "Electronics",
                    Description = "Electronics and embedded systems department"
                }
             );


            modelBuilder.Entity<Teacher>().HasData(
                new Teacher
                {
                    TeacherId = 1,
                    FirstName = "Ahmed",
                    LastName = "Hassan",
                    Email = "ahmed@school.com",
                    Phone = "01012345678",
                    Salary = 15000,
                    DepartmentId = 1
                },
                new Teacher
                {
                    TeacherId = 2,
                    FirstName = "Mona",
                    LastName = "Ali",
                    Email = "mona@school.com",
                    Phone = "01123456789",
                    Salary = 14000,
                    DepartmentId = 1
                },
                new Teacher
                {
                    TeacherId = 3,
                    FirstName = "Omar",
                    LastName = "Mahmoud",
                    Email = "omar@school.com",
                    Phone = "01234567890",
                    Salary = 15500,
                    DepartmentId = 2
                }
            );



            modelBuilder.Entity<Subject>().HasData(
                new Subject
                {
                    SubjectId = 1,
                    Name = "C++ Programming",
                    Description = "Programming fundamentals and OOP",
                    MaxGrade = 100,
                    TeacherId = 1
                },
                new Subject
                {
                    SubjectId = 2,
                    Name = "Database Systems",
                    Description = "Database and SQL",
                    MaxGrade = 100,
                    TeacherId = 2
                },
                new Subject
                {
                    SubjectId = 3,
                    Name = "Web Development",
                    Description = "Web development fundamentals",
                    MaxGrade = 100,
                    TeacherId = 1
                },
                new Subject
                {
                    SubjectId = 4,
                    Name = "Embedded Systems",
                    Description = "Microcontrollers and embedded programming",
                    MaxGrade = 100,
                    TeacherId = 3
                }
            );



            modelBuilder.Entity<ClassRoom>().HasData(
                new ClassRoom
                {
                    ClassRoomId = 1,
                    Name = "Software 1A",
                    GradeLevel = 10,
                    Capacity = 30
                },
                new ClassRoom
                {
                    ClassRoomId = 2,
                    Name = "Electronics 1A",
                    GradeLevel = 10,
                    Capacity = 25
                }
            );


            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentId = 1,
                    FirstName = "Ali",
                    LastName = "Mohamed",
                    Email = "ali@student.com",
                    Phone = "01011111111",
                    DateOfBirth = new DateOnly(2010, 5, 12),
                    ClassRoomId = 1
                },
                new Student
                {
                    StudentId = 2,
                    FirstName = "Omar",
                    LastName = "Ahmed",
                    Email = "omar@student.com",
                    Phone = "01022222222",
                    DateOfBirth = new DateOnly(2010, 8, 20),
                    ClassRoomId = 1
                },
                new Student
                {
                    StudentId = 3,
                    FirstName = "Youssef",
                    LastName = "Hany",
                    Email = "youssef@student.com",
                    Phone = "01033333333",
                    DateOfBirth = new DateOnly(2010, 3, 15),
                    ClassRoomId = 1
                },
                new Student
                {
                    StudentId = 4,
                    FirstName = "Mariam",
                    LastName = "Ali",
                    Email = "mariam@student.com",
                    Phone = "01044444444",
                    DateOfBirth = new DateOnly(2010, 7, 10),
                    ClassRoomId = 2
                },
                new Student
                {
                    StudentId = 5,
                    FirstName = "Salma",
                    LastName = "Mostafa",
                    Email = "salma@student.com",
                    Phone = "01055555555",
                    DateOfBirth = new DateOnly(2009, 12, 22),
                    ClassRoomId = 2
                },
                new Student
                {
                    StudentId = 6,
                    FirstName = "Karim",
                    LastName = "Tarek",
                    Email = "karim@student.com",
                    Phone = "01066666666",
                    DateOfBirth = new DateOnly(2010, 11, 5),
                    ClassRoomId = 2
                }
            );




            modelBuilder.Entity<Enrollment>().HasData(
                new Enrollment
                {
                    EnrollmentId = 1,
                    StudentId = 1,
                    SubjectId = 1,
                    EnrollmentDate = new DateTime(2026, 9, 1),
                    Grade = 90
                },
                new Enrollment
                {
                    EnrollmentId = 2,
                    StudentId = 1,
                    SubjectId = 2,
                    EnrollmentDate = new DateTime(2026, 9, 1),
                    Grade = 85
                },
                new Enrollment
                {
                    EnrollmentId = 3,
                    StudentId = 2,
                    SubjectId = 1,
                    EnrollmentDate = new DateTime(2026, 9, 1),
                    Grade = 78
                },
                new Enrollment
                {
                    EnrollmentId = 4,
                    StudentId = 2,
                    SubjectId = 3,
                    EnrollmentDate = new DateTime(2026, 9, 1),
                    Grade = 88
                },
                new Enrollment
                {
                    EnrollmentId = 5,
                    StudentId = 3,
                    SubjectId = 1,
                    EnrollmentDate = new DateTime(2026, 9, 1),
                    Grade = 95
                },
                new Enrollment
                {
                    EnrollmentId = 6,
                    StudentId = 4,
                    SubjectId = 4,
                    EnrollmentDate = new DateTime(2026, 9, 1),
                    Grade = 82
                },
                new Enrollment
                {
                    EnrollmentId = 7,
                    StudentId = 5,
                    SubjectId = 4,
                    EnrollmentDate = new DateTime(2026, 9, 1),
                    Grade = 91
                },
                new Enrollment
                {
                    EnrollmentId = 8,
                    StudentId = 6,
                    SubjectId = 2,
                    EnrollmentDate = new DateTime(2026, 9, 1),
                    Grade = 76
                }
            );

        }

    }
}

