using System;

namespace Task004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string str = Console.ReadLine();
            int a = 1;
            int b = Convert.ToInt32(str);
            while(a < b)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine($"Число {a} является четным");
                }
                a++;
            }
        }
    }
}
