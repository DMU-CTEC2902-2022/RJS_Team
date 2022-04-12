using Information_and_Technology_College.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;

namespace Information_and_Technology_College.Tests.Controllers
{
    [TestClass]
    public class CyberSecurityControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            CyberSecurityController controller = new CyberSecurityController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Modules()
        {
            // Arrange
            CyberSecurityController controller = new CyberSecurityController();

            // Act
            ViewResult result = controller.Modules() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
