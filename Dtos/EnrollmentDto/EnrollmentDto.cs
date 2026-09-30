using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SchoolApi.Models;

namespace SchoolApi.Dtos.EnrollmentDto
{
    public class EnrollmentDto
    {
        public int EnrollmentId { get; set; }

        public int StudentId { get; set; }


        public int SubjectId { get; set; }


        [Required]
        public DateTime EnrollmentDate { get; set; }

        [Range(0, 100)]
        public decimal Grade { get; set; }
    }
}
