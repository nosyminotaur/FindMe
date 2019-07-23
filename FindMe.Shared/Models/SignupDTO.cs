
namespace FindMe.Shared.Models
{
    public class SignupDTO
    {
        public string email;

        //TODO Add regex to control username characters
        public string username;

        public string password;
    }
}
