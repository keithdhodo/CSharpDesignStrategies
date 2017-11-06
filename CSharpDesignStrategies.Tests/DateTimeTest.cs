﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CSharpDesignStrategies.SingleResponsibilityPrincipleExamples
{
    [TestClass]
    public class DateTimeTest
    {
        [TestMethod]
        public void Dates()
        {
            DateTime date = DateTime.Today;
            date = date.AddHours(5);
            TimeSpan time = date.TimeOfDay;

            //LocalDate nodaDate = SystemClock.Instance.Now.InZone(DateTimeZone.Utc).LocalDateTime.Date;

            //LocalDateTime nodaDateTime = nodaDate.AtMidnight();
        }

        [TestMethod]
        public void KindConfusion()
        {
            DateTime mystery = new DateTime(2012, 4, 25, 19, 41, 0);
            Assert.AreEqual(DateTimeKind.Unspecified, mystery.Kind);

            DateTime mysteryInUtc = mystery.ToUniversalTime();
            DateTime mysteryInLocal = mystery.ToLocalTime();
        }

        [TestMethod]
        public void EqualOrNotEqual()
        {
            DateTime utc1 = new DateTime(2013, 11, 3, 8, 30, 0, DateTimeKind.Utc);
            DateTime utc2 = new DateTime(2013, 11, 3, 9, 30, 0, DateTimeKind.Utc);

            Assert.AreNotEqual(utc1, utc2);

            DateTime local1 = utc1.ToLocalTime();
            DateTime local2 = utc2.ToLocalTime();

            Assert.AreEqual(local1, local2);

            DateTime utc3 = local1.ToUniversalTime();
            DateTime utc4 = local2.ToUniversalTime();

            Assert.AreNotEqual(utc3, utc4);
            Assert.AreEqual(utc1, utc3);
            Assert.AreEqual(utc2, utc4);
        }
    }
}
