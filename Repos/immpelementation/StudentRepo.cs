using SchoolApi.Data;
using SchoolApi.Models;
using SchoolApi.Repos.Interfaces;

namespace SchoolApi.Repos.immpelementation
{
    public class StudentRepo : GenericRepo<Student> , IStudentRepo
    {
        private readonly MyContext c;
        public StudentRepo(MyContext c) : base(c, c.students)
        {
            
        }
    }
}
