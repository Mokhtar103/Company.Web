using System.ComponentModel.DataAnnotations;

namespace Company.Web.Models
{
    public class SignUpViewModel
    {
        [Required(ErrorMessage ="First Name is Required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage ="Invalid Format for Email")]
        public string Email { get; set; }


        [RegularExpression(@"^(?=(.*[A-Z]))(?=(.*[a-z]))(?=(.*\d))(?=(.*\W)).{6,}$", ErrorMessage = "Password must be at least 6 characters long, contain at least one uppercase letter, one lowercase letter, one digit, and one special character.")]
        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is Required")]
        [Compare(nameof(Password), ErrorMessage ="Confirm password does not match password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Required to Agree")]
        public bool isAgree { get; set; }
    }
}
