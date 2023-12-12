using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Linq_Assignment_2.Models
{
    public class Enrolled
    {
        [Key]
        public int EnrolledId { get; set; }

        [ForeignKey(nameof(Student))]
        public int Sid { get; set; }

        [ForeignKey(nameof(Class))]
        public int Cid { get; set; }

        // Navigation properties
        public Student Student { get; set; }
        public Class Class { get; set; }
    }
}
