namespace NationalHolidayApi.Services.ConcreteNationalHolidays
{
    internal class ChristmasNationalHoliday : IConcreteNationalHoliday
    {
        public bool IsHoliday(DateTime date) => date.Month == 12 && date.Day == 25;

    }
}
