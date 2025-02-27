using System.ComponentModel.DataAnnotations;

namespace Mission08_Team0403.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; } // Home, School, Work, Church

        public List<Task> Tasks { get; set; }  // Navigation property
    }
}
// note 2
// note