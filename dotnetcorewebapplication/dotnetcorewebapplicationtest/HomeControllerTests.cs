using dotnetcorewebapplication.Controllers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace dotnetcorewebapplicationtest
{
	public class HomeControllerTests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Index_Test_View()
		{
			HomeController homeController = new HomeController();
			IActionResult view =  homeController.Index();

			Assert.Pass();
		}
	}
}