using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Прием данных анкеты
            Console.WriteLine("Анкета");
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите возраст: ");
            string age = Console.ReadLine();
            Console.Write("Введите город рождения: ");
            string city = Console.ReadLine();
            Console.Write("Введите рост: ");
            string growth = Console.ReadLine();
            Console.Write("Введите вес: ");
            string weight = Console.ReadLine();
            //Вывод анкеты
            Console.WriteLine("Имя: {0}, Фамилия: {1}, Возраст: {2}, Город рождения: {3}, Рост: {4}, Вес: {5}", name, surname, age, city, growth, weight);
            Console.ReadKey();

        }
    }
}
