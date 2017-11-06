using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignStrategies.FactoryPatternExamples
{
    public struct BadDuration
    {
        private readonly long ticks;
        public long Ticks { get { return ticks; } }

        private BadDuration(long ticks)
        {
            this.ticks = ticks;
        }

        public static BadDuration FromMillseconds(long milliseconds)
        {
            return new BadDuration(milliseconds * 10000);
        }

        public static BadDuration FromSeconds(long seconds)
        {
            return new BadDuration(seconds * 10000 * 1000);
        }

        internal static BadDuration FromTicks(int ticks)
        {
            return new BadDuration(ticks);
        }
    }
}
