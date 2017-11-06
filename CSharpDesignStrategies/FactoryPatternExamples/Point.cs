using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignStrategies.FactoryPatternExamples
{
    public sealed class Point
    {
        private readonly int x;
        private readonly int y;

        public int X { get { return x; } }
        public int Y { get { return y; } }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
