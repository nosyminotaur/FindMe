using FindMe.Shared.Helpers;
using System.ComponentModel.DataAnnotations;

namespace FindMe.Shared.Models
{
    public class UsernameLoginDTO
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string email;

        [Required(ErrorMessage = "Username is required")]
        [MinLength(5, ErrorMessage = "Username must be 5 characters long")]
        [RegularExpression(AppRegex.UsernameRegex, ErrorMessage = AppRegex.UsernameError)]
        public string username;

        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(AppRegex.PasswordRegex, ErrorMessage = "Invalid Password conditions")]
        public string password;
    }
}
