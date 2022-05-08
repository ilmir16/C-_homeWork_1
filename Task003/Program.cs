using System;

namespace Task003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string str = Console.ReadLine();
            int a = Convert.ToInt32(str);
            if (a % 2 == 0){
                Console.WriteLine($"Число {a} является четным");
            }
            else{Console.WriteLine($"Число является {a} не четным");}
        }
    }
}
