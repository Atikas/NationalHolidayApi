namespace NationalHolidayApi.Services.ConcreteNationalHolidays
{
    internal class SecondEasterNationalHoliday : IConcreteNationalHoliday
    {
        public bool IsHoliday(DateTime date) => date == EasterNationalHoliday.CalculateEaster(date.Year).AddDays(1);

    }
}
