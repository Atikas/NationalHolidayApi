namespace NationalHolidayApi.Services.ConcreteNationalHolidays
{
    internal class MidsummerNationalHoliday : IConcreteNationalHoliday
    {
        public bool IsHoliday(DateTime date) => date.Month == 6 && date.Day == 24;

    }
}
