using SchoolApi.Data;
using SchoolApi.Repos.Interfaces;

namespace SchoolApi.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyContext c;
        public UnitOfWork(MyContext c , IStudentRepo student , IEnrollmentRepo enrollment , IDepartmentRepo department , ISubjectRepo subject , ITeacherRepo teacher , IClassRoomRepo classroom )
        {
           this.c = c;
            
            Students = student;
            Enrollment = enrollment;
            Department = department;
            Subjects = subject;
            Classroom = classroom;
            Teachers = teacher;

        }
        public IStudentRepo Students { get; }

        public ITeacherRepo Teachers { get; }

        public ISubjectRepo Subjects { get; }

        public IEnrollmentRepo Enrollment { get; }

        public IDepartmentRepo Department { get; }

        public IClassRoomRepo Classroom { get; }

        public int save()
        {
            return c.SaveChanges();
        }
    }
}
