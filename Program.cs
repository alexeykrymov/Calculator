using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Это калькулятор, и вам нужно выбрать операцию:");
            Console.WriteLine("1. Сложение(+)");
            Console.WriteLine("2. Вычетание(-)");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "+":
                    Console.Clear();
                    Console.WriteLine("Введите перове число:");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    int result = num1 + num2;
                    Console.WriteLine($"Результат: {result}");
                    break;

                case "-":
                    Console.Clear();
                    Console.WriteLine("Введите перове число:");
                    int num3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    int num4 = Convert.ToInt32(Console.ReadLine());
                    int result1 = num3 - num4;
                    Console.WriteLine($"Результат: {result1}"); ;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
