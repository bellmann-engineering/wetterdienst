using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wetterdienst.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wetterdienst.Controllers.Tests
{
	[TestClass()]
	public class WeatherForecastControllerTests
	{
		[TestMethod()]
		public void GetCorrectNumberOfWeatherForecatsTest()
		{
			// A A A
			// Arrange
			WeatherForecastController controller = new WeatherForecastController();
			int expected = 5;
			// Act
			int actual = controller.Get().Count();

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}