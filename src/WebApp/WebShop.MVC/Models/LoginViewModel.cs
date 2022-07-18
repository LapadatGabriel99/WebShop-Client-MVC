using System.ComponentModel.DataAnnotations;

namespace WebShop.MVC.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "This field cannot be empty")]
        [MinLength(8, ErrorMessage = "Username has to be at least 8 characters long")]
        [MaxLength(255, ErrorMessage = "Username has to be at most 255 characters long")]
        public string? UsernameOrEmail { get; set; }

        [Required(ErrorMessage = "This field cannot be empty")]
        public string? Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
