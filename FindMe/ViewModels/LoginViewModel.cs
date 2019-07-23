using FindMe.Services;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace FindMe.ViewModels
{
    class LoginViewModel : BaseViewModel
    {
        public ICommand LoginCommand { get; private set; }
        private IAuthService authService;

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
            authService = new AuthService();
        }

        async Task Login()
        {
            //Define username/email properties and then call the authService.Login() method
            var response = await authService.EmailLogin("test@test.com", "Chicken@123");
            Debug.WriteLine(response.success);
            Debug.WriteLine(response.Username);
        }
    }
}
