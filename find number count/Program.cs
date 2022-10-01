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
            Random random = new Random();
            int minValue = 1;
            int maxValue = 27;
            int number = random.Next(minValue, maxValue + 1);
            int result = 0;
            int minBorder = 100;
            int maxBorder = 999;

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
