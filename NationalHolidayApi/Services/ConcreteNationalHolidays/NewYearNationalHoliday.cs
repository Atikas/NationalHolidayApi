namespace NationalHolidayApi.Services.ConcreteNationalHolidays
{
    internal class NewYearNationalHoliday : IConcreteNationalHoliday
    {
        public bool IsHoliday(DateTime date) => date.Month == 1 && date.Day == 1;

    }
}
