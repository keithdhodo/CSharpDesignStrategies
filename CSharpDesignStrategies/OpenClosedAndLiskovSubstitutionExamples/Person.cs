using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignStrategies.OpenClosedAndLiskovSubstitutionExamples
{
    public class Person
    {
        public string Name { get; set; }
    }

    public class Spy : Person
    {

    }
}
