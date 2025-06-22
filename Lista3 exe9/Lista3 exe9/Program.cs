using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_exe9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Os trinta primeiros valores da série de Fibonacci:");

            
            int a = 1;
            int b = 1;

            Console.Write(a + ", " + b);

            for (int i = 2; i < 30; i++) 
            {
                int temp = a + b; 
                Console.Write(", " + temp);

                a = b;
                b = temp; 
            }

            Console.WriteLine(); 
        }
    }
    }
}