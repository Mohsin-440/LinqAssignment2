using System.ComponentModel.DataAnnotations;

namespace Linq_Assignment_2.Models
{
    public class Student
    {
        [Key]
        public int Sid { get; set; }
        [Required]
        public string SName { get; set; }
        [Required]
        public string Major { get; set; }
        [Required]
        public string Standing { get; set; }
        public DateOnly Birthdate { get; set; }

        // Navigation property
        public List<Enrolled> Enrollments { get; set; }
    }
}
