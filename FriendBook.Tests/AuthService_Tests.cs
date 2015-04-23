using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FriendBook.Utils;

namespace FriendBook.Tests
{
    [TestClass]
    public class AuthService_Tests
    {
        private AuthService _authService;

        [TestInitialize]
        public void Initialize()
        {
            _authService = new AuthService();
        }

        [TestMethod]
        public void CanAuthenticate_wrongUserNameAndPassword_ReturnFalse()
        {
            //Arrange
            var userName = "some_user_name";
            var password = "some_user_password";

            //Act
            var actualResult = _authService.CanAuthenticate(userName, password);

            //Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void CanAuthenticate_goodUserNameButWrongPassword_ReturnFalse()
        {
            //Arrange
            var userName = "user1";
            var password = "some_user_password";

            //Act
            var actualResult = _authService.CanAuthenticate(userName, password);

            //Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void CanAuthenticate_wrongUserNameButGoodPassword_ReturnFalse()
        {
            //Arrange
            var userName = "some_user_name";
            var password = "password1";

            //Act
            var actualResult = _authService.CanAuthenticate(userName, password);

            //Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void CanAuthenticate_goodUserNameAndPassword_ReturnTrue()
        {
            //Arrange
            var userName = "user1";
            var password = "password1";

            //Act
            var actualResult = _authService.CanAuthenticate(userName, password);

            //Assert
            Assert.IsFalse(actualResult);
        }
    }
}
