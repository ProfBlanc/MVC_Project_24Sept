using System.ComponentModel.DataAnnotations;

namespace WebApplication4MVC.Models
{
    public class ProfileModel
    {

        [Required]
        [Range(1, 100)]
        public int Id { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Name should be at least 3 chars")]
        public string Name { get; set; } = string.Empty;
        [Required]
        [Range(18, 65)]
        public int Age { get; set; }

    }
}
