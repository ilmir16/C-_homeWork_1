using System;

namespace Task007
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");
            string str = Console.ReadLine();
            int i = Convert.ToInt32(str);
            int i1 = i / 100;
            int i2 = (i / 10) % 10;
            int i3 = i % 10; 
            string s1 = Convert.ToString(i1);
            string s2 = Convert.ToString(i3);
            string s = s1 + s2;
            int sum = Convert.ToInt32(s);
            Console.WriteLine(sum);
        }
    }
}
