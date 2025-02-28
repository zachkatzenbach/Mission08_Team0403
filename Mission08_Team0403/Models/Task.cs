using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission08_Team0403.Models
{
    public class Task
    {
        [Key]
        public int TaskId { get; set; }

        [Required]
        public string TaskName { get; set; }

        [Required]
        public int Quadrant { get; set; }  

        [Required]
        public int CategoryId { get; set; }  // Foreign Key
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        public DateTime? DueDate { get; set; }

        public bool Completed { get; set; } = false; 
    }
}