using System;

namespace Task006
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int value = rand.Next(10, 90);
            Console.WriteLine($"Рандомное число {value}");
            int a = value / 10;
            int b = value % 10;
            if (a > b)
            {
                Console.Write($"Число {a} больше числа {b} ");
            }
            else if (b > a)
            {
                Console.Write($"Число {b} больше числа {a} ");
            }
            else {Console.Write("Числа равны");}
        }
    }
}
