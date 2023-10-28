using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BakhtiyarovDR.Sprint3.Task5.V5.Lib;

namespace Tyuiu.BakhtiyarovDR.Sprint3.Task5.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Бахтияров Д. Р. | АСОиУБ-23-3";
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- Спринт #3                                                               -");
            Console.WriteLine("- Тема: Вложенные циклы                                                   -");
            Console.WriteLine("- Задание #5                                                              -");
            Console.WriteLine("- Вариант #5                                                              -");
            Console.WriteLine("- Выполнил: Бахтияров Динар Русланович | АСОиУБ-23-3                      -");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- УСЛОВИЕ:                                                                -");
            Console.WriteLine("- Посчитать алгебраическую сумму при x = 5                                -");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- ИСХОДНЫЕ ДАННЫЕ:                                                        -");
            Console.WriteLine("---------------------------------------------------------------------------");

            int x = 5;
            Console.WriteLine("X = " + x);
            int Start1 = 1;
            Console.WriteLine("Первое начальное значение = " + Start1);
            int Stop1 = 3;
            Console.WriteLine("Первое конечное значение = " + Stop1);
            int Start2 = 1;
            Console.WriteLine("Второе начальное значение = " + Start2);
            int Stop2 = 10;
            Console.WriteLine("Второе конечное значение = " + Stop2);

            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- РЕЗУЛЬТАТ:                                                              -");
            Console.WriteLine("---------------------------------------------------------------------------");

            DataService ds = new DataService();
            Console.WriteLine(ds.GetSumSumSeries(x, Start1, Start2, Stop1, Stop2));

            Console.ReadKey();
        }
    }
}
