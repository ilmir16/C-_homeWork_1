using System;

namespace Task005
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");
            string str = Console.ReadLine();
            int num = Convert.ToInt32(str);
            Console.WriteLine($"Вторая цифра числа {num} = {(num / 10) % 10}"); 
        }
    }
}
