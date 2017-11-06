using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignStrategies.StrategyPatternExamples
{
    public class AgeComparer : IComparer<EnhancedPerson>
    {
        public int Compare(EnhancedPerson x, EnhancedPerson y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }
}
