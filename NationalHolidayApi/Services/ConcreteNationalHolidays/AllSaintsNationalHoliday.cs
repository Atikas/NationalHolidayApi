namespace NationalHolidayApi.Services.ConcreteNationalHolidays
{
    internal class AllSaintsNationalHoliday : IConcreteNationalHoliday
    {
        public bool IsHoliday(DateTime date) => date.Month == 11 && date.Day == 1;

    }
}
