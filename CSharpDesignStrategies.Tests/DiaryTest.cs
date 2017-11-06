using CSharpDesignStrategies.InterfaceExamples;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NodaTime;
using System;

namespace CSharpDesignStrategies.DependencyInjectionExamples
{
    [TestClass]
    public class DiaryTest
    {
        [TestMethod]
        public void FormatToday_Iso_Utc()
        {
            DateTime date = new DateTime(1970, 1, 1).ToUniversalTime();
            var clock = new StubClock(Instant.FromDateTimeUtc(date));
            Diary diary = new Diary(clock, CalendarSystem.Iso, DateTimeZone.Utc);

            string today = diary.FormatToday();
            Assert.AreEqual("1970-01-01", today);
        }

        [TestMethod]
        public void FormatToday_Iso_NegativeOffset()
        {
            DateTimeZone zone = DateTimeZone.ForOffset(Offset.FromHours(-8));
            var clock = new StubClock(Instant.FromUtc(1970, 01, 01, 00, 00));
            Diary diary = new Diary(clock, CalendarSystem.Iso, zone);

            string today = diary.FormatToday();
            Assert.AreEqual("1969-12-31", today);
        }
    }
}
