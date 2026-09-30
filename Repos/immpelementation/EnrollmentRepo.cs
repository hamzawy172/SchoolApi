using Microsoft.EntityFrameworkCore;
using SchoolApi.Data;
using SchoolApi.Models;
using SchoolApi.Repos.Interfaces;

namespace SchoolApi.Repos.immpelementation
{
    public class EnrollmentRepo : GenericRepo<Enrollment>, IEnrollmentRepo
    {
        private readonly MyContext c;
        
        public EnrollmentRepo(MyContext c ) : base(c , c.enrollments)
        {
            this.c = c;
        }

    }
}
