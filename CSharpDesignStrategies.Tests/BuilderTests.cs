using Microsoft.VisualStudio.TestTools.UnitTesting;
using NodaTime;

namespace CSharpDesignStrategies.BuilderPatternExample
{
    [TestClass]
    public class BuilderTests
    {
        [TestMethod]
        public void BuildPeriod()
        {
            var period = Period.FromHours(5);
            period = Period.FromHours(5) + Period.FromMinutes(3);

            Period built = new PeriodBuilder() { Hours = 5, Minutes = 3}.Build();

            Assert.AreEqual(0, built.Seconds);
            Assert.AreEqual(period, built);
        }

        [TestMethod]
        public void BadPeriodTest()
        {
            ShyPeriod badPeriod = new ShyPeriod.Builder() { }.Build();
        }
    }
}
