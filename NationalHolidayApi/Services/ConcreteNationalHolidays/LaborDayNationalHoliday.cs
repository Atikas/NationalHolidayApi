namespace NationalHolidayApi.Services.ConcreteNationalHolidays
{
    internal class LaborDayNationalHoliday : IConcreteNationalHoliday
    {
        public bool IsHoliday(DateTime date) => date.Month == 5 && date.Day == 1;

    }
}
