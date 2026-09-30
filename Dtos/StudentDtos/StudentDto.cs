using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SchoolApi.Models;

namespace SchoolApi.Dtos.StudentDtos
{
    public class StudentDto
    {
        public int StudentId { get; set; }

        [Required, MaxLength(50)]
        public string FirstName { get; set; }

        [Required, MaxLength(50)]
        public string LastName { get; set; }

        [Required, EmailAddress, MaxLength(150)]
        public string Email { get; set; }

        [Phone, MaxLength(20)]
        public string? Phone { get; set; }

        [Required]
        public DateOnly DateOfBirth { get; set; }

        public int ClassRoomId { get; set; }

    }
}
