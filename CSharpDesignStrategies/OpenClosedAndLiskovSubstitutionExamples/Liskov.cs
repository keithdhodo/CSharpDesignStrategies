using NodaTime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignStrategies.OpenClosedAndLiskovSubstitutionExamples
{
    public class Liskov
    {
        //static void PrintSequence<T>(IEnumerable<T> items)
        //{
        //    //if (items is IList<T>)
        //    //{
        //    //    // Do Something
        //    //}
        //    foreach(T item in items)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //static void PrintCurrentTime(IClock clock)
        //{
        //    Instant now = clock.Now;
        //}

        //static void ReportSpy(Spy spy)
        //{
        //    Person spyAsPerson = spy;
        //    string name = spyAsPerson.Name;
        //}

        //static void LeakyAbstraction(Stream stream)
        //{
        //    if (stream.CanSeek)
        //    {
        //        // stream.Seek(0, SeekOrigin.Begin);
        //        stream.Position = 0;
        //    }
        //}

        //public void ArraysBreakLiskov()
        //{
        //    IList<string> strings = new string[5];
        //    strings.Add("Hi"); // cannot add here because the array is fixed size
        //}

        public virtual string Foo()
        {
            return Foo(0);
        }

        public virtual string Foo(int x)
        {
            return "x = " + x;
        }

        public virtual string Bar()
        {
            return Foo() + " there";
        }
    }

    public class Breakage : Liskov
    {
        public override string Foo()
        {
            return "goodbye";
        }
    }
}
