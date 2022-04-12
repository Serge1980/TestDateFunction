using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDateFunction
{
    public class DateService
    {
        public void PrintDateDiff(DateTime startDate, DateTime endDate)
        {
            //упорядочим даты
            var dates = DateToSortOrder(startDate, endDate);
            startDate = dates.Item1;
            endDate = dates.Item2;
           
            var totalDays = (endDate - startDate).TotalDays;
            var years = GetYears(startDate, endDate);
            var months = GetMonths(startDate, endDate, years);
            var days = GetDays(startDate, endDate, years, months);

            Console.WriteLine(years);
            Console.WriteLine(months);
            Console.WriteLine(days);
        }

        private int GetYears(DateTime startDate, DateTime endDate)
        {
            return endDate.Year - startDate.Year;
        }

        //получить разницу месяцев
        private int GetMonths(DateTime startDate, DateTime endDate, int yearsTotal)
        {
            var result = 0;
            endDate = endDate.AddYears(-yearsTotal);
            var dates = DateToSortOrder(startDate, endDate);
            result = dates.Item2.Month - dates.Item1.Month;
            return result;
        }

        //получить разницу дней
        private int GetDays(DateTime startDate, DateTime endDate, int yearsTotal,int monthsTotal)
        {
            var result = 0;
            endDate = endDate.AddYears(-yearsTotal);
            endDate = endDate.AddMonths(-monthsTotal);
            var dates = DateToSortOrder(startDate, endDate);
            result = dates.Item2.Day - dates.Item1.Day;
            return result;
        }


        //упорядочить даты
        private (DateTime, DateTime) DateToSortOrder(DateTime startDate, DateTime endDate)
        {
            var list = new List<DateTime>();
            list.Add(startDate);
            list.Add(endDate);
            (DateTime, DateTime) result = (list.Min(), list.Max());
            return result;
        }
    }
}
