using NationalHolidayApi.Services.ConcreteNationalHolidays;

namespace NationalHolidayApi.Services
{
    public interface INationalHoliday
    {
        bool IsHoliday(DateTime date);
    }
    public class NationalHoliday : INationalHoliday
    {
        private readonly List<IConcreteNationalHoliday> _concreteNationalHolidayStrategyLt = new List<IConcreteNationalHoliday>
        {
            new NewYearNationalHoliday(),
            new RestorationOfIndependenceNationalHolidayLt(),
            new IndependenceDayNationalHolidayLt(),
            new EasterNationalHoliday(),
            new SecondEasterNationalHoliday(),
            new LaborDayNationalHoliday(),
            new MidsummerNationalHoliday(),
            new StateNationalHolidayLt(),
            new AssumptionNationalHoliday(),
            new AllSaintsNationalHoliday(),
            new AllSoulsNationalHolidayLt(),
            new ChristmasEveNationalHoliday(),
            new ChristmasNationalHoliday(),
            new SecondChristmasNationalHoliday()
        };



        public bool IsHoliday(DateTime date) => _concreteNationalHolidayStrategyLt.Exists(holiday => holiday.IsHoliday(date));

    }
}
