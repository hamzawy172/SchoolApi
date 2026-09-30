using SchoolApi.Data;
using SchoolApi.Models;
using SchoolApi.Repos.Interfaces;

namespace SchoolApi.Repos.immpelementation
{
    public class DepartmentRepo : GenericRepo<Department> , IDepartmentRepo
    {
        private readonly MyContext c;

        public DepartmentRepo(MyContext c) : base(c,c.departments)
        {
            
        }
    }
}
