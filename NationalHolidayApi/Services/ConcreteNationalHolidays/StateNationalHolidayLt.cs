namespace NationalHolidayApi.Services.ConcreteNationalHolidays
{
    internal class StateNationalHolidayLt : IConcreteNationalHoliday
    {
        public bool IsHoliday(DateTime date) => date.Month == 7 && date.Day == 6;

    }
}
