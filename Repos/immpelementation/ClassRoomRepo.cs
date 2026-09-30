using SchoolApi.Data;
using SchoolApi.Models;
using SchoolApi.Repos.Interfaces;

namespace SchoolApi.Repos.immpelementation
{
    public class ClassRoomRepo : GenericRepo<ClassRoom> , IClassRoomRepo
    {
        private readonly MyContext c;
        public ClassRoomRepo(MyContext c) : base(c,c.classRooms)
        {
            
        }
    }
}
