using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignStrategies
{
    public class Singleton
    {
        private static readonly Lazy<Singleton> lazyInstance = new Lazy<Singleton>(() => new Singleton(), true);

        //private static class SingletonHolder
        //{
        //    // private static readonly object mutex = new object();
        //    // private static volatile Singleton instance;
        //    internal static readonly Singleton instance = new Singleton();

        //    // Empty static constuctor - forces laziness
        //    static SingletonHolder() { }
        //}

        private Singleton()
        {
            Console.WriteLine("Singleton constructor");
        }

        public static Singleton Instance { get { return lazyInstance.Value; } }
        //{
        //    // double check locking
        //    if (instance == null)
        //    {
        //        // single check locking
        //        lock (mutex)
        //        {
        //            if (instance == null)
        //            {
        //                instance = new Singleton();
        //            }
        //            // return instance; --> moved below for double check
        //        }
        //    }
        //    return instance;
        //}

        public static void SayHi()
        {
            Console.WriteLine("Hello there");
        }

        public void DoSomething()
        {

        }
    }
}
