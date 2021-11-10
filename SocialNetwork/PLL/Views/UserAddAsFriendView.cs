using System;
using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;

namespace SocialNetwork.PLL.Views
{
    public class UserAddAsFriendView
    {
        UserService userService;

        public UserAddAsFriendView(UserService userService)
        {
            this.userService = userService;
        }

        public void Show(User user)
        {
            var searchFriend = new UserAddAsFriendData();
            
            Console.WriteLine("Введите почтовый адрес друга: ");
            searchFriend.Email = Console.ReadLine();

            try
            {
                var friend = this.userService.FindByEmail(searchFriend);
                
                SuccessMessage.Show("Вы успешно добавили друга!");
                SuccessMessage.Show("Ваш друг " + friend.Email);
                
                Program.userMenuView.Show(user);
            }
            catch(UserNotFoundException)
            {
                AlertMessage.Show("Пользователь не найден");
            }
        }
    }
}