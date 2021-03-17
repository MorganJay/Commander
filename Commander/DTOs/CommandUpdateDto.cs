using System.ComponentModel.DataAnnotations;

namespace Commander.DTOs
{
    public class CommandUpdateDto
    {
        [Required]
        [StringLength(250, MinimumLength = 10, ErrorMessage = "HowTo must be between 10 and 250 characters")]
        public string HowTo { get; set; }

        [Required]
        public string Line { get; set; }

        [Required]
        public string Platform { get; set; }
    }
}