using System;

namespace Homework_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свою Фамилию");
            string Surname = Console.ReadLine();
            Console.WriteLine("Введите свое Имя");
            string Name = Console.ReadLine();
            Console.WriteLine("Введите свой город проживания");
            string Gorod = Console.ReadLine();
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine(Surname + " " + Name + " " + Gorod);
            Console.ReadLine();
        }
    }
}
