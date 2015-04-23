using System.Collections.Generic;

namespace FriendBook.Models
{
    public class UsersDictionary
    {
        private readonly Dictionary<string,string> _users = new Dictionary<string,string>();

        public UsersDictionary()
        {
            _users.Add("user1", "password1");
            _users.Add("user2", "password2");
        }

        public bool UserExists(string userName)
        {
            return _users.ContainsKey(userName.Trim());
        }

        public string GetPassword(string userName)
        {
            return _users[userName];
        }
    }
}
