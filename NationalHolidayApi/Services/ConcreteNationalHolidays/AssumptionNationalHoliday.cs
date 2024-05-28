namespace NationalHolidayApi.Services.ConcreteNationalHolidays
{
    internal class AssumptionNationalHoliday : IConcreteNationalHoliday
    {
        public bool IsHoliday(DateTime date) => date.Month == 8 && date.Day == 15;

    }
}
