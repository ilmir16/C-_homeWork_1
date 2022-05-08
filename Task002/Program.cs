using System;

namespace Task002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер от 0 до 6 : ");
            string str = Console.ReadLine();
            int a = Convert.ToInt32(str);
            if (a == 0)
            {
                Console.Write("Понедельник");
            }
            else if(a == 1)
            {
                Console.Write("Вторник");
            }
            else if(a == 2)
            {
                Console.Write("Среда");
            }
            else if(a == 3)
            {
                Console.Write("Четверг");
            }
            else if(a == 4)
            {
                Console.Write("Пятница");
            }
            else if(a == 5)
            {
                Console.Write("Суббота");
            }
            else if(a == 6)
            {
                Console.Write("Воскресенье");
            }
            else
            {
                Console.Write("Вы ввели неправильный номер");
            }
        }
    }
}
