using FriendBook.ViewModel;
using FriendBook.Models;
using System.Collections.Generic;

namespace FriendBook.ViewModels
{
    public class FriendsListViewModel : MainViewModel
    {
        public FriendsListViewModel()
        {
            Friends = FriendsDictionary.GetFriends();
        }

        public IList<Friend> Friends { get; set; }
    }
}
