namespace NationalHolidayApi.Services.ConcreteNationalHolidays
{
    internal class ChristmasEveNationalHoliday : IConcreteNationalHoliday
    {
        public bool IsHoliday(DateTime date) => date.Month == 12 && date.Day == 24;

    }
}
