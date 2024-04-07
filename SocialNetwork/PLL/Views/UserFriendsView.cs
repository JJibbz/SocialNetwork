using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class UserFriendsView
    {
        public void Show(IEnumerable<User> friends)
        {
            Console.WriteLine("Мои друзья");

            if (friends.Count() == 0)
            {
                Console.WriteLine("У вас нет друзей =(");
                return;
            }

            friends.ToList().ForEach(friend =>
            {
                Console.WriteLine($"Почтовый адрес друга: {friend.Email}. Имя друга: {friend.FirstName} {friend.LastName}");
            });
        }
    }
}
