namespace NationalHolidayApi.Services.ConcreteNationalHolidays
{
    internal class SecondChristmasNationalHoliday : IConcreteNationalHoliday
    {
        public bool IsHoliday(DateTime date) => date.Month == 12 && date.Day == 26;

    }
}
