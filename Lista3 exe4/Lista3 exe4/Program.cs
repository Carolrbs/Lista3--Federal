using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_exe4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 5; // Changed the number to 5

            Console.WriteLine($"Multiplication Table for {number}:");

            for (int i = 1; i <= 10; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} x {i} = {result}");
            }
        }
    }
}
