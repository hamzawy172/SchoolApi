using SchoolApi.Data;
using SchoolApi.Models;
using SchoolApi.Repos.Interfaces;

namespace SchoolApi.Repos.immpelementation
{
    public class TeacherRepo : GenericRepo<Teacher> , ITeacherRepo
    {
        private readonly MyContext c;
        public TeacherRepo(MyContext c ): base(c,c.teachers)
        {
            
        }
    }
}
