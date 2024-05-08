using DevopsDemo.Controllers;

namespace DevopsDemo.test
{
    [TestFixture]
    public class WeatherForecastControllerTests
    {
        [Test]
        public void Get()
        {
            // Arrange
            WeatherForecastController controller = new WeatherForecastController();

            // Act
            var result = controller.Get();

            Assert.IsNotNull(result);
        }
    }
}