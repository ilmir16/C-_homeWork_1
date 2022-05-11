using System;

namespace Task008
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число!");
            string str1 = Console.ReadLine();
            int i1 = Convert.ToInt32(str1);
            Console.Write("Введите второе число!");
            string str2 = Console.ReadLine();
            int i2 = Convert.ToInt32(str2);
            if(i1 % i2 == 0)
            {
                Console.WriteLine($"Число {i1} кратно {i2}");
            }
            else
            {
                Console.WriteLine($"Остаток при делении = {i1 % i2}");
            }
        }
    }
}
