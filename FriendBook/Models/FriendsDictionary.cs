using System.Collections.Generic;

namespace FriendBook.Models
{
    public class FriendsDictionary
    {
        private static readonly List<Friend> _friends = new List<Friend>();

        static FriendsDictionary()
        {
            _friends.Add(new Friend()
            {
                Age=22,
                Gender="Male",
                Height=200,
                Weight=120,
                Name="Jan",
                Surname="Kowalski"
            });

            _friends.Add(new Friend()
            {
                Age = 28,
                Gender = "Female",
                Height = 170,
                Weight = 70,
                Name = "Maria",
                Surname = "Kowalska"
            });

            _friends.Add(new Friend()
            {
                Age = 28,
                Gender = "Female",
                Height = 150,
                Weight = 45,
                Name = "Basia",
                Surname = "Kwiatkowska"
            });

            _friends.Add(new Friend()
            {
                Age = 22,
                Gender = "Female",
                Height = 168,
                Weight = 45,
                Name = "Monika",
                Surname = "Monikowska"
            });

            _friends.Add(new Friend()
            {
                Age = 22,
                Gender = "Female",
                Height = 168,
                Weight = 45,
                Name = "Anna",
                Surname = "Kowalska"
            });

            _friends.Add(new Friend()
            {
                Age = 30,
                Gender = "Male",
                Height = 168,
                Weight = 50,
                Name = "Kazik",
                Surname = "Kowalski"
            });
        }

        public static IList<Friend> GetFriends()
        {
            return _friends;
        }
    }
}
