using FindMe.Shared.Helpers;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace FindMe.Shared.Models
{
    public class EmailLoginDTO
    {
        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(AppRegex.EmailRegex, ErrorMessage = "Invalid Email Format")]
        public string email;

        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(AppRegex.PasswordRegex, ErrorMessage = "Invalid Password conditions")]
        public string password;
    }
}
