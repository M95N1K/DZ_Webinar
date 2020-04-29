using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Работу выполнил Виль Виктор
    Задание №4:
    Написать программу обмена значениями двух переменных:
        а) с использованием третьей переменной;
	    б) *без использования третьей переменной.
*/
namespace Less_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;
            #region Решение а

            Console.WriteLine($"a = {a} , b = {b}");

            int tmp = a;
            a = b;
            b = tmp;

            Console.WriteLine();
            Console.WriteLine($"a = {a} , b = {b}");
            #endregion

            #region Решение б

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine();
            Console.WriteLine($"a = {a} , b = {b}");
            #endregion

            Console.ReadLine();
        }
    }
}
