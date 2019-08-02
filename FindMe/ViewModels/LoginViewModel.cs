using FindMe.Services;
using FindMe.Shared.Helpers;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace FindMe.ViewModels
{
    class LoginViewModel : BaseViewModel
    {
        #region private fields

        private string userData;
        private string password;
        private string errorMessage;
        private UserDataType userDataType;
        private readonly IAuthService authService;
        #endregion

        /// <summary>
        /// Holds username or email
        /// </summary>
        public string UserData
        {
            get
            {
                return userData;
            }
            set
            {
                userData = value;
                OnUserDataChanged();
                OnPropertyChanged("UserData");
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        public string ErrorMessage
        {
            get
            {
                return errorMessage;
            }
            set
            {
                errorMessage = value;
                OnPropertyChanged(errorMessage);
            }
        }

        public ICommand LoginCommand { get; private set; }

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
            authService = new AuthService();
        }

        private async Task Login()
        {
            if (userDataType == UserDataType.Email)
            {
                var response = await authService.EmailLogin(userData, password);
                if (response.success)
                {
                    //Go to home page
                }
                else
                {
                    //show error message
                }
            }
        }

        private void OnUserDataChanged()
        {
            if (AppRegex.IsValidUsername(userData))
            {
                userDataType = UserDataType.Username;
                return;
            }
            if (AppRegex.IsValidEmail(userData))
            {
                userDataType = UserDataType.Email;
                return;
            }
            userDataType = UserDataType.None;
        }
    }

    //To determine type of userdata
    enum UserDataType
    {
        Username,
        Email,
        None
    }
}
