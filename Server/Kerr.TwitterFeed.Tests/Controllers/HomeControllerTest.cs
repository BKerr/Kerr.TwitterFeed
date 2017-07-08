namespace Kerr.TwitterFeed.Tests.Controllers
{
    using System.Web.Mvc;

    using Kerr.TwitterFeed.Controllers;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class HomeControllerTest
    {
        #region ///  Methods  ///

        [TestMethod]
        public void Index()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }

        #endregion
    }
}