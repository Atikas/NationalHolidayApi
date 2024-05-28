namespace NationalHolidayApi.Services.ConcreteNationalHolidays
{
    internal class IndependenceDayNationalHolidayLt : IConcreteNationalHoliday
    {
        public bool IsHoliday(DateTime date) => date.Month == 3 && date.Day == 11;
    }
}
