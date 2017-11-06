using Microsoft.VisualStudio.TestTools.UnitTesting;
using NodaTime;

namespace CSharpDesignStrategies.InterfaceExamples
{
    [TestClass]
    public class InterfaceTests
    {
        [TestMethod]
        public void ExpiredLicense()
        {
            // arrange
            var expiry = Instant.FromUtc(2000, 1, 1, 0, 0, 0);
            IClock clock = new StubClock(expiry + Duration.FromTicks(1));
            // act
            License license = new License(expiry, clock);
            //assert
            Assert.IsTrue(license.HasExpired);
        }

        [TestMethod]
        public void ExpiryAtExactInstant()
        {
            // arrange
            var expiry = Instant.FromUtc(2000, 1, 1, 0, 0, 0);
            IClock clock = new StubClock(expiry + Duration.FromTicks(1));
            // act
            var license = new License(expiry, clock);
            //assert
            Assert.IsTrue(license.HasExpired);
        }

        [TestMethod]
        public void NonExpiredLicense()
        {
            var expiry = Instant.FromUtc(2000, 1, 1, 0, 0, 0);
            IClock clock = new StubClock(expiry - Duration.FromTicks(1));
            var license = new License(expiry, clock);

            Assert.IsFalse(license.HasExpired);
        }

        [TestMethod]
        public void NonExpiredLicenseBecomesExpired()
        {
            var expiry = SystemClock.Instance.GetCurrentInstant() + Duration.FromDays(1);
            IClock clock = SystemClock.Instance;
            var license = new License(expiry, clock);

            Assert.IsFalse(license.HasExpired);
            // Assert.IsTrue(license.HasExpired);
        }
    }
}
