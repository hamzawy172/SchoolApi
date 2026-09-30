using System.ComponentModel.DataAnnotations;

namespace SchoolApi.Models
{
    public class ClassRoom
    {
        public int ClassRoomId { get; set; }

        [Required ,MaxLength(50)]
        public string Name { get; set; }

        [Required ,Range(1,12)]
        public int GradeLevel { get; set; }

        [Required ,Range(1,100)]
        public int Capacity { get; set; }

        public ICollection<Student> students { get; set; }
        = new List<Student>();
    }
}
