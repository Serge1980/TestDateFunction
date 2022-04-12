using System;

namespace TestDateFunction
{
    class Program
    {
       
        static void Main(string[] args)
        {
            DateService ds = new DateService();
            ds.PrintDateDiff(new DateTime(2020, 06, 30), new DateTime(2021, 07, 31));
           
        }

        
    }
}
//Задача:

//Требуется написать функцию, которая принимает на вход две даты, а на выходе печатает в консоль строку с информацией о количестве полных лет, месяцев и дней между этими датами.

//Пример:

//DateDiff(new DateTime(2020, 06, 30), new DateTime(2021, 07, 31));

//// Полных лет 1, месяцев 1, дней 1