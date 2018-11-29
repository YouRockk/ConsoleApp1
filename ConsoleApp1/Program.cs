using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите целое число a");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число a");
            }

            int[] arr = new[] {Int32.Parse(Console.ReadLine()), 5, a};
            foreach (var i in arr)
            {
                Console.Write(i + ", ");
            }
        }
    }
}