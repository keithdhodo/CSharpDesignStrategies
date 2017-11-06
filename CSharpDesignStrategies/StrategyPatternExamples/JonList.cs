using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignStrategies.StrategyPatternExamples
{
    public class JonList<T>
    {
        public void Sort(Comparison<T> comparison)
        {
        }

        public void Sort(IComparer<T> comparison)
        {
        }
    }
}
