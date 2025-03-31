using System.ComponentModel.DataAnnotations;

namespace Company.Web.Models
{
    public class ResetPasswordViewModel
    {
        [RegularExpression(@"^(?=(.*[A-Z]))(?=(.*[a-z]))(?=(.*\d))(?=(.*\W)).{6,}$", ErrorMessage = "Password must be at least 6 characters long, contain at least one uppercase letter, one lowercase letter, one digit, and one special character.")]
        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is Required")]
        [Compare(nameof(Password), ErrorMessage = "Confirm password does not match password")]
        public string ConfirmPassword { get; set; }

        public string Email { get; set; }

        public string Token { get; set; }
    }
}
