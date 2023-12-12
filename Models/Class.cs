using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Linq_Assignment_2.Models
{
    public class Class
    {
        [Key]
        public int Cid { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string RoomNumber { get; set; }

        [ForeignKey(nameof(Faculty))]
        public int Fid { get; set; }

        // Navigation properties
        public List<Enrolled> Enrollments { get; set; }
        public Faculty Faculty { get; set; }
    }
}
