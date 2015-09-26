using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Подсчет зарплаты
            Console.Write("Введите вашу зарплату за месяц: ");
            decimal m_salary = decimal.Parse(Console.ReadLine());
            decimal y_salary = m_salary * 12; //Для большей точности расчет будем вести из годовой зарплаты
            decimal d_salary = y_salary / 365;
            decimal w_salary = d_salary * 7;
            decimal h_salary = d_salary / 24;
            decimal minutes_salary = h_salary / 60;
            decimal seconds_salary = minutes_salary / 60;

            //Вывод результатов
            Console.WriteLine("Ваша зарплата: {0} за год, {1} за месяц, {2} за неделю, {3} за день, {4} за час, {5} за минуту, {6} за секунду",y_salary,m_salary,w_salary,d_salary,h_salary,minutes_salary,seconds_salary);
            Console.ReadKey();
        }
    }
}
