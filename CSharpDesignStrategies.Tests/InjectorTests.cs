using Microsoft.VisualStudio.TestTools.UnitTesting;
using NodaTime;

namespace CSharpDesignStrategies.DependencyInjectionExamples
{
    [TestClass]
    public class InjectorTests
    {
        [TestMethod]
        public void TestCreatingAnInjector()
        {
            Injector injector = new Injector();
            injector.Bind<IClock, SystemClock>();
            injector.Bind<DateTimeZone>(DateTimeZone.Utc);
            injector.Bind<Instant>(Instant.FromUtc(2000, 1, 1, 0, 0, 0));
            injector.Bind<CalendarSystem>(CalendarSystem.Iso);
            DiaryPresenter presenter = injector.Resolve<DiaryPresenter>();
            // DiaryPresenter presenter = injector.CreateDiaryPresenter();
            presenter.Start();
        }
    }
}
