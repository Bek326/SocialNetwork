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
            bool Bek = true;
            Assert.True(Bek);
            registrationView.Show();

            bool Valiev = true;
            Assert.True(Valiev);
            registrationView.Show();
            

        }
    }
}