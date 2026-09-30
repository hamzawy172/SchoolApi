using System.ComponentModel.DataAnnotations;
using SchoolApi.Models;

namespace SchoolApi.Dtos.ClassRoomDtos
{
    public class ClassRoomDto
    {
        public int ClassRoomId { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Required, Range(1, 12)]
        public int GradeLevel { get; set; }

        [Required, Range(1, 100)]
        public int Capacity { get; set; }

    }
}
