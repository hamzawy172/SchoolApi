using System.ComponentModel.DataAnnotations;

namespace SchoolApi.Dtos.DepartmentDtos
{
    public class UpdateDepartmentDto
    {

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }
    }
}
