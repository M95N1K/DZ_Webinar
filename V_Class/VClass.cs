using System;

/*
Работу выполнил Виль Виктор
    Задание №6:
    *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).

*/

namespace VClass
{
    public class Cons //Клас для некоторых работ с консолью
    {
        // Вывод в консоль сообщение по координатам с переходом на новую строку
        public static void PrintL()
        {
            Console.WriteLine();
        }
        public static void PrintL(char message)
        {
            Console.WriteLine(message);
        }
        public static void PrintL(string message)
        {
            Console.WriteLine(message);
        }
        public static void PrintL(char message, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(message);
        }
        public static void PrintL(string message, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(message);
        }

        // Вывод в консоль сообщение по координатам
        public static void Print(char message)
        {
            Console.Write(message);
        }
        public static void Print(string message)
        {
            Console.Write(message);
        }
        public static void Print(char message, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(message);
        }
        public static void Print(string message, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(message);
        }

        // Ожидание нажатия Enter с выводом перед этим сообщения
        public static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите Enter");
            Console.ReadLine();
        }
        public static void Pause(char message)
        {
            Console.WriteLine();
            Console.WriteLine(message);
            Console.ReadLine();
        }
        public static void Pause(string message)
        {
            Console.WriteLine();
            Console.WriteLine(message);
            Console.ReadLine();
        }

        // Ожидание нажатия любой кнопки с выводом перед этим сообщения
        public static void PauseK()
        {
            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую кнопку");
            Console.ReadKey();
        }
        public static void PauseK(char message)
        {
            Console.WriteLine();
            Console.WriteLine(message);
            Console.ReadKey();
        }
        public static void PauseK(string message)
        {
            Console.WriteLine();
            Console.WriteLine(message);
            Console.ReadKey();
        }

        public static string Read()
        {
            return Console.ReadLine();
        }
        public static int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        public static double ReadDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

    }
}
