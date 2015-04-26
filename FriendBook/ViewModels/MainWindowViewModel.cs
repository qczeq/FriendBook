using FriendBook.ViewModel;

namespace FriendBook.ViewModels
{
    public class MainWindowViewModel : MainViewModel
    {

        public MainWindowViewModel()
        {
            var passwordViewModel = new PasswordViewModel();
            passwordViewModel.SignIn = () =>
            {
                CurrentViewModel = new FriendsListViewModel();
            };

            CurrentViewModel = passwordViewModel;
        }


        private MainViewModel _currentViewModel;

        public MainViewModel CurrentViewModel
        {
            get { return _currentViewModel; }
            set
            {
                _currentViewModel = value;
                RaisePropertyChanged(() => CurrentViewModel);
            }
        }

    }
}
