using System.ComponentModel.DataAnnotations;

namespace Practice.Models
{
    public class ContactForm
    {
        [Required]
        public string Name { get; set; } = "";

        [Range(18, 120)]
        public int Age { get; set; }

    }
}
