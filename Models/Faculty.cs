using System.ComponentModel.DataAnnotations;

namespace Linq_Assignment_2.Models
{
    public class Faculty
    {
        [Key]
        public int Fid { get; set; }
        public string FName { get; set; }
        public string DeptId { get; set; }
        public string Standing { get; set; }
        public DateOnly Birthdate { get; set; }

        // Navigation property
        public List<Class> Classes { get; set; }
    }
}
