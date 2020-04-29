using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Работу выполнил Виль Виктор
    Задание №1:
    Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
        а) используя  склеивание;
	    б) используя форматированный вывод;
	    в) используя вывод со знаком $.


*/

namespace Less_1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите возраст: ");
            byte age = Convert.ToByte(Console.ReadLine());
            Console.Write("Введите рост (в метрах): ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вес (в килограммах): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Имя: " + name + ". Фамилия: " + surname + ". Возраст: " + age + ". Рост: "+ height + "м. Вес: " + weight + "кг.");
            Console.WriteLine("Имя: {0}. Фамилия: {1}. Возраст: {2}. Рост: {3:F}м. Вес: {4:F}кг." , name, surname, age, height, weight);
            Console.WriteLine($"Имя: {name}. Фамилия: {surname}. Возраст: {age}. Рост: {height}м. Вес: {weight}кг.");

            Console.ReadLine();
        }
    }
}
