using FriendBook.Models;

namespace FriendBook.Utils
{
    public class AuthService
    {
        private UsersDictionary _usersDictionary;

        public AuthService()
        {
            _usersDictionary = new UsersDictionary();
        }

        public bool CanAuthenticate(string userName, string password)
        {
            if (_usersDictionary.UserExists(userName))
            {
                var userPassword = _usersDictionary.GetPassword(userName);
                return string.Equals(userPassword, password);
            }

            return false;
        }

        public void Authenticate(string userName, string password)
        {
            //Do something - not important for demo purpose
        }
    }
}
