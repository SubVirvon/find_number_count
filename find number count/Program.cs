using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_number_count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int result = 0;
            int minBorder = 100;
            int maxBorder = 999;

            Console.Write("Введи число из промежутка (1 <= N <= 27): ");
            number = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i <= maxBorder; i += number)
            {
                if(i >= minBorder)
                {
                    result++;
                }
            }

            Console.WriteLine("Количество трехзначных чисел, кратных " + number + ": " + result);
            Console.ReadKey();
        }
    }
}
