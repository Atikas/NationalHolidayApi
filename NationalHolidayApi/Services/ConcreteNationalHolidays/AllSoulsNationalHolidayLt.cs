namespace NationalHolidayApi.Services.ConcreteNationalHolidays
{
    internal class AllSoulsNationalHolidayLt : IConcreteNationalHoliday
    {
        public bool IsHoliday(DateTime date) => date.Month == 11 && date.Day == 2;

    }
}
