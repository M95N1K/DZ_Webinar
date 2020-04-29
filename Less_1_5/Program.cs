using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VClass;


/*
Работу выполнил Виль Виктор
    Задание №5:
    а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
    б) *Сделать задание, только вывод организовать в центре экрана.
    в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).

*/

namespace Less_1_5
{
    class Program
    {

        static void Print(string message , int x , int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            string msg = "Имя: Виктор. Фамилия: Виль. Город проживания: Омск";
            int x = (Console.WindowWidth / 2) - (msg.Length / 2);
            int y = Console.WindowHeight / 2;
            //Решение а
            //Console.WriteLine(msg);

            // Решение б

            //Console.SetCursorPosition(x, y);
            //Console.WriteLine(msg);


            // Решение в
            Print(msg, x, y);

            //Cons.PrintL(msg, x , y);

            Cons.PauseK("");
        }
    }
}
