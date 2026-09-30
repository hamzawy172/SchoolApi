using System.ComponentModel.DataAnnotations;
using SchoolApi.Models;

namespace SchoolApi.Dtos.DepartmentDtos
{
    public class DepartmentDto
    {
        public int DepartmentId { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }


       
    }
}
