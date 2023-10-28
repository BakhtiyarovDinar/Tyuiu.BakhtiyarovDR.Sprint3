using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BakhtiyarovDR.Sprint3.Task6.V19.Lib;

namespace Tyuiu.BakhtiyarovDR.Sprint3.Task6.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Бахтияров Д. Р. | АСОиУБ-23-3";
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("* Спринт #3                                                                -");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                              -");
            Console.WriteLine("* Задание #6                                                               -");
            Console.WriteLine("* Вариант #19                                                              -");
            Console.WriteLine("* Выполнил: Бахтияров Динар Русланович | АСОиУБ-23-3                       -");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("* УСЛОВИЕ:                                                                 -");
            Console.WriteLine("* Написать программу, которая подсчитает кол-во делителей меньше 8          ");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------");

            DataService service1 = new DataService();


            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("- ИСХОДНЫЕ ДАННЫЕ:                                                         -");
            Console.WriteLine("----------------------------------------------------------------------------");


            int x = 10;
            int y = 15;


            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("- РЕЗУЛЬТАТ:                                                              --");
            Console.WriteLine("----------------------------------------------------------------------------");

            double res = service1.GetSumTheDivisors(x, y);

            Console.WriteLine("По моим подсчётам " + res);


            Console.ReadKey();
        }
    }
}
