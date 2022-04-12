using Information_and_Technology_College.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;

namespace Information_and_Technology_College.Tests.Controllers
{
    [TestClass]
    public class AccountControllerTest
    {
        //Test method for the index page
        [TestMethod]
        public void Index()
        {
            // Arrange
            AccountController controller = new AccountController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        //Test method for the register page
        [TestMethod]
        public void Register()
        {
            // Arrange
            AccountController controller = new AccountController();

            // Act
            ViewResult result = controller.Register() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        //Test method for the login page
        [TestMethod]
        public void Login()
        {
            // Arrange
            AccountController controller = new AccountController();

            // Act
            ViewResult result = controller.Login() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        //Test method for the logged in page
        [TestMethod]
        public void LoggedIn()
        {
            // Arrange
            AccountController controller = new AccountController();

            // Act
            ViewResult result = controller.LoggedIn() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
