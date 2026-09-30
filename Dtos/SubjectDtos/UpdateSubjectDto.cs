using System.ComponentModel.DataAnnotations;

namespace SchoolApi.Dtos.SubjectDtos
{
    public class UpdateSubjectDto
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        [Required, Range(1, 100)]
        public int MaxGrade { get; set; }

        public int TeacherId { get; set; }
    }
}
