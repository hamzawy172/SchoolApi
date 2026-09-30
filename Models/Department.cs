using System.ComponentModel.DataAnnotations;

namespace SchoolApi.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

        [Required , MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }


        public ICollection<Teacher> teachers { get; set; }
        = new List<Teacher>();
    }
}
