using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolApi.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }

        [Required , MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string ?Description { get; set; }

        [Required , Range(1,100)]
        public int MaxGrade { get; set; }

        public int TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public Teacher Teacher { get; set; }

        public ICollection<Enrollment> enrollments { get; set; }
        = new HashSet<Enrollment>();
    }
}
