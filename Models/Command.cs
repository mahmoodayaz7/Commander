using System.ComponentModel.DataAnnotations;

namespace Commander.Models
{
    public class Command
    {
        [Key]
        public int Id { get; set; }
        [Required (ErrorMessage = "You must enter HowTo"), MinLength(3, ErrorMessage = "How to must be at least 3 characters long"), MaxLength(250, ErrorMessage = "How to can't be more than 250 characters long"), Display(Name = "How to")]
        public string HowTo { get; set; }
        [Required]
        public string Line { get; set; }
        [Required]
        public string Platform { get; set; }
    }
}