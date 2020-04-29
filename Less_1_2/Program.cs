using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Работу выполнил Виль Виктор
    Задание №2:
    Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
*/
namespace Less_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите рост (в метрах): ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вес (в килограммах): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Индекс массы равен: {0}", (weight / (height * height)));

            Console.ReadLine();
        }
    }
}
