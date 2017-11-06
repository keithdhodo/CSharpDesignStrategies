using CSharpDesignStrategies.StrategyPatternExamples;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSharpDesignStrategies.Tests
{
    [TestClass]
    public class StrategyPatternTests
    {
        public static readonly ReadOnlyCollection<EnhancedPerson> People = new List<EnhancedPerson>()
        {
            new EnhancedPerson { Name = "Jon", Age = 35 },
            new EnhancedPerson { Name = "Rob", Age = 44 },
            new EnhancedPerson {Name = "Holly", Age = 36 },
            new EnhancedPerson {Name = "Tom", Age = 8 }
        }.AsReadOnly();

        [TestMethod]
        public void StrategyPatternTestsSortingByAge()
        {
            List<EnhancedPerson> list = new List<EnhancedPerson>(People);
            list.Sort(CompareByAge);
            list.Sort((x, y) => x.Age.CompareTo(y.Age));
            list.Sort(new AgeComparer());

            foreach (EnhancedPerson person in list)
            {
                Console.WriteLine(person);
            }
        }

        public delegate int Comparison<T>(T x, T y);

        static int CompareByAge(EnhancedPerson x, EnhancedPerson y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }
}
