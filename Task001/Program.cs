using System;

namespace Task001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            string sa = Console.ReadLine();
            Console.Write("Введите второе число: ");
            string sb = Console.ReadLine();
            double a = Convert.ToDouble(sa);
            double b = Convert.ToDouble(sb);
            if (a == b * b)
            {
                Console.Write($"Число {a} является квадратом числа {b}");
            }
            else
            {
                Console.Write($"Число {a} не является квадратом числа {b}");
            }
        }
    }
}
