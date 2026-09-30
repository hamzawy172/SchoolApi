using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SchoolApi.Models;

namespace SchoolApi.Dtos.TeacherDtos
{
    public class TeacherDto
    {
        public int TeacherId { get; set; }

        [Required, MaxLength(50)]
        public string FirstName { get; set; }

        [Required, MaxLength(50)]
        public string LastName { get; set; }

        [Required, EmailAddress, MaxLength(150)]
        public string Email { get; set; }

        [Phone, MaxLength(20)]
        public string? Phone { get; set; }

        [Required, Range(1, int.MaxValue)]
        public decimal Salary { get; set; }

        public int DepartmentId { get; set; }



    }
}
