using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CSharpDesignStrategies
{
    [TestClass]
    public class SingletonClient
    {
        [TestMethod]
        public void UseSingleton()
        {
            Console.WriteLine("Start of text");
            Singleton s1 = Singleton.Instance;
            s1.DoSomething();
            Singleton s2 = Singleton.Instance;
            Assert.AreSame(s1, s2);
        }

        [TestMethod]
        public void SayHi()
        {
            Singleton.SayHi();
        }
    }
}
