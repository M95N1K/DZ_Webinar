using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Работу выполнил Виль Виктор
    Задание №3:
    а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
    б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

*/

namespace Less_1_3
{
    class Program
    {
        static double distanceBetweenPoints(int x1 , int y1, int x2 , int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static void Main(string[] args)
        {
            //int x1 = 10;
            //int y1 = 5;
            //int x2 = 2;
            //int y2 = 10;
            //double result = 0;

            //result = distanceBetweenPoints(10, 5, 2, 10);

            Console.WriteLine("Расстояние между точками равно: {0:F}" , distanceBetweenPoints(10, 5, 2, 10));

            Console.ReadLine();
        }
    }
}
