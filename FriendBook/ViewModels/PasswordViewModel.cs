using FriendBook.Utils;
using FriendBook.ViewModel;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Windows.Input;

namespace FriendBook.ViewModels
{
    public class PasswordViewModel : MainViewModel
    {
        public Action SignIn;

        private AuthService _authService;

        public PasswordViewModel()
        {
            _authService = new AuthService();
        }

        public string Login { get; set; }

        public string Password { get; set; }

        public ICommand SignInCommand
        {
            get { return new RelayCommand(OnSignIn); }
        }

        private void OnSignIn()
        {
            if (SignIn != null)
            {
                if (_authService.CanAuthenticate(Login, Password))
                {
                    SignIn();
                }
            }
        }
    }
}
