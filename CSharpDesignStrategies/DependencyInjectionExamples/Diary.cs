using NodaTime;
using NodaTime.Text;

namespace CSharpDesignStrategies.DependencyInjectionExamples
{
    public class Diary
    {
        private readonly LocalDatePattern OutputPattern =
                LocalDatePattern.CreateWithInvariantCulture("yyyy-MM-dd");

        private readonly IClock clock;
        private readonly CalendarSystem calendar;
        private readonly DateTimeZone timezone;

        public Diary(IClock clock, CalendarSystem calendar, DateTimeZone timezone)
        {
            this.clock = clock;
            this.calendar = calendar;
            this.timezone = timezone;
        }

        public string FormatToday()
        {
            LocalDate date = clock.GetCurrentInstant().InZone(timezone, calendar).LocalDateTime.Date;
            return OutputPattern.Format(date);
        }
    }
}
