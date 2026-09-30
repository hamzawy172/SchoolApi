using System.ComponentModel.DataAnnotations;

namespace SchoolApi.Dtos.EnrollmentDto
{
    public class UpdateEnrollmentDto
    {
        public int StudentId { get; set; }


        public int SubjectId { get; set; }


        [Required]
        public DateTime EnrollmentDate { get; set; }

        [Range(0, 100)]
        public decimal Grade { get; set; }
    }
}
