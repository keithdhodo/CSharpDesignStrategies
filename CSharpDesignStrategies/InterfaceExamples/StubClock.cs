using System;
using NodaTime;

namespace CSharpDesignStrategies.InterfaceExamples
{
    public class StubClock : IClock
    {
        private readonly Instant Now;

        public StubClock(Instant now)
        {
            Now = now;
        }

        Instant IClock.GetCurrentInstant()
        {
            return Now;
        }
    }
}