using System.ComponentModel.DataAnnotations;

namespace SchoolApi.Dtos.ClassRoomDtos
{
    public class UpdateClassRoomDto
    {
        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Required, Range(1, 12)]
        public int GradeLevel { get; set; }

        [Required, Range(1, 100)]
        public int Capacity { get; set; }

    }
}
