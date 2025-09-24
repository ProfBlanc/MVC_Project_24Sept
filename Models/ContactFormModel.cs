using System.ComponentModel.DataAnnotations;

namespace WebApplication4MVC.Models
{
    public class ContactFormModel
    {
        //DataAnnotations
        [Required(ErrorMessage ="Name is Required")]
        [MinLength(3, ErrorMessage = "Name must be at least 3 characters")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [MinLength(10, ErrorMessage = "Message too short. 10 chars min")]
        public string Message { get; set; } = string.Empty;

    }
}
