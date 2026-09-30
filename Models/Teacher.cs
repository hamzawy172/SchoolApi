using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolApi.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }

        [Required , MaxLength(50)]
        public string FirstName { get; set; }

        [Required , MaxLength(50)]
        public string LastName { get; set; }

        [Required , EmailAddress , MaxLength(150)]
        public string Email { get; set; }

        [Phone , MaxLength(20)]
        public string? Phone { get; set; }

        [Required , Range(1,int.MaxValue)]
        public decimal Salary { get; set; }

        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }

        public ICollection<Subject> subjects { get; set; }
        = new List<Subject>();

    }
}
