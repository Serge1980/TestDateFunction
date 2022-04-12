using System;

namespace TestDateFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            DateService ds = new DateService();
            ds.PrintDateDiff(new DateTime(2020, 06, 30), new DateTime(2021, 07, 31));
            ds.PrintDateDiff(new DateTime(2019, 01, 29), new DateTime(2022, 04, 13));
            ds.PrintDateDiff(new DateTime(2019, 02, 09), new DateTime(2022, 04, 13));
            ds.PrintDateDiff(new DateTime(2019, 01, 09), new DateTime(2022, 04, 13));
        }
    }
}
