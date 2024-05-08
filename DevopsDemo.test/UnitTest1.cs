using DevopsDemo.Controllers;

namespace DevopsDemo.test
{
    [TestFixture]
    public class Tests
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