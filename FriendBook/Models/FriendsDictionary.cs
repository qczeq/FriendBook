using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace FriendBook.Models
{
    public class FriendsDictionary
    {
        private static readonly List<Friend> _friends = new List<Friend>();

        static FriendsDictionary()
        {
            _friends.Add(new Friend()
            {
                Age = 22,
                Gender = "Male",
                Height = 200,
                Weight = 120,
                Name = "Jan",
                Surname = "Kowalski",
                Avatar = new BitmapImage(new Uri(@"/FriendBook;component/Avatars/01.jpg", UriKind.Relative))
            });

            _friends.Add(new Friend()
            {
                Age = 28,
                Gender = "Female",
                Height = 170,
                Weight = 70,
                Name = "Maria",
                Surname = "Kowalska",
                Avatar = new BitmapImage(new Uri(@"/FriendBook;component/Avatars/02.jpg", UriKind.Relative))
            });

            _friends.Add(new Friend()
            {
                Age = 28,
                Gender = "Female",
                Height = 150,
                Weight = 45,
                Name = "Basia",
                Surname = "Kwiatkowska",
                Avatar = new BitmapImage(new Uri(@"/FriendBook;component/Avatars/03.jpg", UriKind.Relative))
            });

            _friends.Add(new Friend()
            {
                Age = 22,
                Gender = "Female",
                Height = 168,
                Weight = 45,
                Name = "Monika",
                Surname = "Monikowska",
                Avatar = new BitmapImage(new Uri(@"/FriendBook;component/Avatars/04.jpg", UriKind.Relative))
            });

            _friends.Add(new Friend()
            {
                Age = 22,
                Gender = "Female",
                Height = 168,
                Weight = 45,
                Name = "Anna",
                Surname = "Kowalska",
                Avatar = new BitmapImage(new Uri(@"/FriendBook;component/Avatars/05.jpg", UriKind.Relative))
            });

            _friends.Add(new Friend()
            {
                Age = 30,
                Gender = "Male",
                Height = 168,
                Weight = 50,
                Name = "Kazik",
                Surname = "Kowalski",
                Avatar = new BitmapImage(new Uri(@"/FriendBook;component/Avatars/06.jpg", UriKind.Relative))
            });
        }

        public static IList<Friend> GetFriends()
        {
            return _friends;
        }
    }
}
