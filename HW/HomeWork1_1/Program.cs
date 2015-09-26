using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Сумма двух чисел:");
            Console.WriteLine(a+b);
            Console.ReadKey();
        }
    }
}
