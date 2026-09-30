using SchoolApi.Repos.Interfaces;

namespace SchoolApi.UnitOfWork
{
    public interface IUnitOfWork
    {
        IStudentRepo Students {  get; }
        ITeacherRepo Teachers { get; }
        ISubjectRepo Subjects { get; }
        IEnrollmentRepo Enrollment { get; }
        IDepartmentRepo Department { get; }
        IClassRoomRepo Classroom { get; }

        int save();
        
    }
}
