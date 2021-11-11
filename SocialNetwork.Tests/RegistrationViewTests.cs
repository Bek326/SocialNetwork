using System;
using NUnit.Framework;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using SocialNetwork.PLL.Views;

namespace SocialNetwork.Tests
{
    [TestFixture]
    public class RegistrationViewTests
    {
        RegistrationView registrationView = new RegistrationView(new UserService());
        
        [Test]
        public void ShowTests()
        {
            string[] words = {"Bek", "Valiev", "123456789", "bekking326@gmail.com"};
            registrationView.Show();
            Assert.IsNotEmpty(words);
            
            Console.ReadLine();
            
        }
    }
}
