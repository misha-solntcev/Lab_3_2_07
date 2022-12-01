using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 7. Найти все целые числа из промежутка от 1 до 300, 
    у которых ровно пять делителей. */

namespace Lab_3_2_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 300; i > 0; i--)
            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                        count++;
                }
                if (count == 5)
                    Console.WriteLine($"i = {i}, count={count}");
            }
            Console.ReadKey();
        }
    }
}
