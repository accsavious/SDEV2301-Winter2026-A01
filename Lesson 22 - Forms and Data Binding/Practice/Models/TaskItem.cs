using System.ComponentModel.DataAnnotations;

namespace Practice.Models
{
    public class TaskItem
    {
        [Required]
        public string Title { get; set; } = "";

        [Required]
        public DateTime? DueDate { get; set; }

        public bool IsComplete { get; set; }
    }
}
