using SchoolApi.Data;
using SchoolApi.Models;
using SchoolApi.Repos.Interfaces;

namespace SchoolApi.Repos.immpelementation
{
    public class SubjectRepo : GenericRepo<Subject> , ISubjectRepo
    {
        private readonly MyContext c;
        public SubjectRepo(MyContext c) : base(c,c.subjects)
        {
            
        }
    }
}
