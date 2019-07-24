using System.ComponentModel.DataAnnotations;

namespace FindMe.Shared.Models
{
    public class EmailLoginDTO
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string email;

        [Required(ErrorMessage = "Password is required")]
        //TODO Add regex
        public string password;
    }
}
