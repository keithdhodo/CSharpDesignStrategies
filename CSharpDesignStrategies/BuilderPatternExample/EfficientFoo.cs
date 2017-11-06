using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignStrategies.BuilderPatternExample
{
    public sealed class EfficientFoo
    {
        private string name;

        private EfficientFoo()
        {

        }

        public sealed class Builder
        {
            private EfficientFoo foo;

            public string Name { get { return foo.name; } set { foo.name = value; } }

            public EfficientFoo Build()
            {
                EfficientFoo copy = foo;
                foo = null;
                return copy;
            }
        }
    }
}

