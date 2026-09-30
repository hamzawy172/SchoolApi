using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SchoolApi.Models;

namespace SchoolApi.Dtos.SubjectDtos
{
    public class SubjectDto
    {
        public int SubjectId { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        [Required, Range(1, 100)]
        public int MaxGrade { get; set; }

        public int TeacherId { get; set; }
  

    }
}
