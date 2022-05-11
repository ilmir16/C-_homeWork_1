using System;

namespace Task009
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string str = Console.ReadLine();
            int i = Convert.ToInt32(str);
            if (i < 100)
            {
                Console.WriteLine("3 цифры нету");
            }
            else 
            {
                while(i > 1000){
                    i = i / 10;
                }
                Console.WriteLine($"Третья цифра равна {i % 10}");
            }

        }
    }
}
