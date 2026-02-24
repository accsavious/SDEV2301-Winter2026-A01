using System.ComponentModel.DataAnnotations;

namespace Lesson22Forms.Models
{
    public class Poll
    {
        [Required]
        public string Name { get; set; } = "";

        [Required]
        public string City { get; set; } = "";

        [Required]
        public string? Candidate { get; set; }

        [Range(0, 100)]
        public int ConfidenceLevel { get; set; }
    }
}
