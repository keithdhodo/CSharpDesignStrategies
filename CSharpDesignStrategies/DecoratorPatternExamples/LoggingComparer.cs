using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignStrategies.DecoratorPatternExamples
{
    public sealed class LoggingComparer<T> : IComparer<T>
    {
        private readonly IComparer<T> comparer;

        public LoggingComparer(IComparer<T> comparer)
        {
            this.comparer = comparer;
        }

        public int Compare(T x, T y)
        {
            int result = comparer.Compare(x, y);
            Console.WriteLine("Compare({0}, {1}) == {2}", x, y, result);
            return result;
        }
    }
}
