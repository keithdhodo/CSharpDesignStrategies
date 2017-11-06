using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignStrategies.BuilderPatternExample
{
    public sealed class ShyPeriod
    {
        private readonly string name;

        public string Name { get { return name; } }

        private ShyPeriod(Builder builder)
        {
            this.name = builder.Name;
        }

        public sealed class Builder
        {
            public string Name { get; set; }

            public ShyPeriod Build()
            {
                return new ShyPeriod(this);
            }
        }
    }
}
