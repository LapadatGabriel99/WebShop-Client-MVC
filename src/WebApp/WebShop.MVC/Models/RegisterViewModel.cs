using System.ComponentModel.DataAnnotations;

namespace WebShop.MVC.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "This field is required.")]
        [MinLength(8, ErrorMessage = "Username has to be at least 8 characters long.")]
        [MaxLength(255, ErrorMessage = "Username has to be at most 255 characters long.")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [EmailAddress(ErrorMessage = "This thield must be an email address.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string? ConfirmPassword { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(255, ErrorMessage = "First name has to be at most 255 characters long.")]
        public string? Firstname { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(255, ErrorMessage = "Last name has to be at most 255 characters long.")]
        public string? Lastname { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(255, ErrorMessage = "Address 1 has to be at most 255 characters long.")]
        public string? AddressFirstLine { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(255, ErrorMessage = "Address 2 has to be at most 255 characters long.")]
        public string? AddressSecondLine { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(255, ErrorMessage = "City has to be at most 255 characters long.")]
        public string? City { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(255, ErrorMessage = "Region has to be at most 255 characters long.")]
        public string? Region { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(255, ErrorMessage = "Country has to be at most 255 characters long.")]
        public string? Country { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(255, ErrorMessage = "Phone number has to be at most 255 characters long.")]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(255, ErrorMessage = "Zip code has to be at most 255 characters long.")]
        public string? ZipCode { get; set; }
    }
}
