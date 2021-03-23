using NUnit.Framework;
using Weather.Core;

namespace WeatherTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void summary_test_cool()
        {
            int tempC = 8;
            var summary = TemperatureHelper.GetSummary(tempC);
            Assert.IsTrue(summary == "Cool");
        }
        [Test]
        public void summary_test_freezing()
        {
            int tempC = -8;
            var summary = TemperatureHelper.GetSummary(tempC);
            Assert.IsTrue(summary == "Freezing");
        }
        [Test]
        public void summary_test_hot()
        {
            int tempC = 24;
            var summary = TemperatureHelper.GetSummary(tempC);
            Assert.IsTrue(summary == "Hot");
        }
        [Test]
        public void summary_test_sweltering()
        {
            int tempC = 28;
            var summary = TemperatureHelper.GetSummary(tempC);
            Assert.IsTrue(summary == "Sweltering");
        }
    }
}