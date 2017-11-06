using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignStrategies.FactoryPatternExamples
{
    [TestClass]
    public class SimpleImmutabilityTests
    {
        [TestMethod]
        public void FromSeconds()
        {
            BadDuration duration = BadDuration.FromSeconds(5);
            Assert.AreEqual(50000000, duration.Ticks);
        }

        [TestMethod]
        public void Ticks()
        {
            BadDuration duration = BadDuration.FromMillseconds(10);
            Assert.AreEqual(10, duration.Ticks);
        }
    }
}
