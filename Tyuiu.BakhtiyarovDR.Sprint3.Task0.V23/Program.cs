using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BakhtiyarovDR.Sprint3.Task0.V23.Lib;

namespace Tyuiu.BakhtiyarovDR.Sprint3.Task0.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Бахтияров Д.Р. | АСОиУБ-23-3";
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("- Спринт3                                                                   -");
            Console.WriteLine("- Тема: Оператор цикла for                                                  -");
            Console.WriteLine("- Задание #0                                                                -");
            Console.WriteLine("- Вариант #23                                                               -");
            Console.WriteLine("- Выполнил: Бахтияров Динар Русланович| АСОиУБ-23-3                         -");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("- УСЛОВИЕ:                                                                  -");
            Console.WriteLine("- Написать программу используя цикл for, которая вычисляет сумму ряда по    -");
            Console.WriteLine("- формуле, при X=1,5                                                        -");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("- ИСХОДНЫЕ ДАННЫЕ:                                                          -");
            Console.WriteLine("-----------------------------------------------------------------------------");
            double value = 1.5;
            int startValue = 1;
            int stopValue = 10;
            Console.WriteLine("Переменная X = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("- РЕЗУЛЬТАТ:                                                                -");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value, startValue, stopValue));
            Console.ReadLine();
        }
    }
}
