
using System.Windows.Media.Imaging;
namespace FriendBook.Models
{
    public class Friend
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }

        public BitmapImage Avatar { get; set; }
    }
}
