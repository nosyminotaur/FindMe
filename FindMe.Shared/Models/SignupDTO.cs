
using FindMe.Shared.Helpers;
using System.ComponentModel.DataAnnotations;

namespace FindMe.Shared.Models
{
    public class SignupDTO
    {
        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(AppRegex.EmailRegex, ErrorMessage = "Invalid Email Format")]
        public string email;

        [Required(ErrorMessage = "Username is required")]
        [MinLength(5, ErrorMessage = "Username must be 5 characters long")]
        [RegularExpression(AppRegex.UsernameRegex, ErrorMessage = "Invalid Username Format")]
        public string username;

        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(AppRegex.PasswordRegex, ErrorMessage = "Invalid Password conditions")]
        public string password;
    }
}
