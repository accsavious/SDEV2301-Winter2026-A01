using System.ComponentModel.DataAnnotations;

namespace Lesson22Forms.Models
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
