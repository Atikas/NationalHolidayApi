namespace NationalHolidayApi.Services.ConcreteNationalHolidays
{
    internal class RestorationOfIndependenceNationalHolidayLt : IConcreteNationalHoliday
    {
        public bool IsHoliday(DateTime date) => date.Month == 2 && date.Day == 16;
    }
}
