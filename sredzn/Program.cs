using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = WriteData();
            b = WriteData();
            c = WriteData();

            Console.WriteLine("СредАрф. = " + ((double)((a + b + c)/3)));
        }
        static int WriteData()
        {
            string temp;

            while (true)
            {
                Console.WriteLine("Введите значение");
                temp = Console.ReadLine();
                try
                {
                    return int.Parse(temp);
                }
                catch (Exception)
                {
                    Console.WriteLine("Не правильный тип данных");
                    continue;
                }
            }
        }
    }
}
