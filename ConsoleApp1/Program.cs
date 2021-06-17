using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i_count_shrek, i_count_bitch, i_count_nigga;
            i_count_shrek = WriteData();
            i_count_bitch = WriteData();
            i_count_nigga = WriteData();

            int i_convert_shrek_to_bitch = 2;
            int i_convert_shrek_to_nigga = 4;
            int i_convert_bitch_to_nigga = 6;

            string sz_name_shrek = "ШрекКоины";
            string sz_name_bitch = "БичКоины";
            string sz_name_nigga = "НигаКоины";

            Console.WriteLine(sz_name_shrek + " : " + i_count_shrek);
            Console.WriteLine(sz_name_bitch + " : " + i_count_bitch);
            Console.WriteLine(sz_name_nigga + " : " + i_count_nigga);

            Console.WriteLine("Конвентор");

            Console.WriteLine(sz_name_shrek + " -> " + sz_name_bitch + " : " + ((double)i_count_shrek * i_convert_shrek_to_bitch));
            Console.WriteLine(sz_name_bitch + " -> " + sz_name_nigga + " : " + ((double)i_count_bitch / i_convert_shrek_to_bitch));

            Console.WriteLine(sz_name_shrek + " -> " + sz_name_nigga + " : " + ((double)i_count_shrek * i_convert_shrek_to_nigga));
            Console.WriteLine(sz_name_nigga + " -> " + sz_name_shrek + " : " + ((double)i_count_nigga / i_convert_shrek_to_nigga));

            Console.WriteLine(sz_name_nigga + " -> " + sz_name_bitch + " : " + ((double)i_count_nigga * i_convert_bitch_to_nigga));
            Console.WriteLine(sz_name_bitch + " -> " + sz_name_nigga + " : " + ((double)i_count_bitch / i_convert_bitch_to_nigga));
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
