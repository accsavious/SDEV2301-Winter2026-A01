using System.ComponentModel.DataAnnotations;

namespace FormLesson.Models
{
    public class ContactForm
    {
        [Required]
        [MaxLength(20)]
        public string Name { get; set; } = "";
        [Range(18, 130)]
        public int Age { get; set; }
    }
}
