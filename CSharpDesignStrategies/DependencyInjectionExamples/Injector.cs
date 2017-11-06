using CSharpDesignStrategies.InterfaceExamples;
using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignStrategies.DependencyInjectionExamples
{
    /// <summary>
    /// IoC Container as it is currently written. Commented out code will yield a manual IoC container
    /// </summary>
    public class Injector
    {
        private Dictionary<Type, Func<object>> providers = new Dictionary<Type, Func<object>>();

        public void Bind<TKey, TConcrete>() where TConcrete : TKey
        {
            providers[typeof(TKey)] = () => ResolveByType(typeof(TConcrete));
        }

        private object ResolveByType(Type type)
        {
            Console.WriteLine("Resolving... {0}", type);
            var constructor = type.GetConstructors().SingleOrDefault();
            if (constructor != null)
            { 
                var arguments = constructor.GetParameters().Select(parameterInfo => Resolve(parameterInfo.ParameterType)).ToArray();
                return constructor.Invoke(arguments);
            }
            var instanceField = type.GetField("Instance");
            return instanceField.GetValue(null);
        }

        private object Resolve(Type type)
        {
            Func<object> provider;
            if (providers.TryGetValue(type, out provider))
            {
                return provider();
            }
            return ResolveByType(type);
        }

        public void Bind<T>(T instance)
        {
            providers[typeof(T)] = () => instance;
        }

        public TKey Resolve<TKey>()
        {
            return (TKey)Resolve(typeof(TKey));
        }

        //public IClock CreateClock()
        //{
        //    return SystemClock.Instance;
        //}

        //public License CreateLicense()
        //{
        //    return new License(Instant.FromUtc(1970, 01, 01, 00, 00), CreateClock());
        //}

        //public DateTimeZone GetUtcTimeZone()
        //{
        //    return DateTimeZone.Utc;
        //}

        //public CalendarSystem GetIsoCalendarSystem()
        //{
        //    return CalendarSystem.Iso;
        //}

        //public Diary CreateDiary()
        //{
        //    return new Diary(CreateClock(), GetIsoCalendarSystem(), GetUtcTimeZone());
        //}

        //public DiaryPresenter CreateDiaryPresenter()
        //{
        //    return new DiaryPresenter(CreateDiary(), CreateLicense());
        //}
    }
}
