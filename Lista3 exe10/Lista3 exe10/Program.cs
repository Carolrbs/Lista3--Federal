using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_exe10
{
    internal class Program
    {
        static void Main(string[] args)
        {                Console.Write("Digite um número não negativo para calcular o fatorial: ");
                int n = int.Parse(Console.ReadLine());
                while (n < 0)
                {
                    Console.WriteLine("Erro: O número deve ser não negativo.");
                    Console.Write("Digite um número não negativo para calcular o fatorial: ");
                    n = int.Parse(Console.ReadLine());
                }
                long fatorial = 1;
                for (int i = 1; i <= n; i++)
                {
                    fatorial *= i;
                }
                Console.WriteLine($"{n}! = {fatorial}");
                Console.Write("Deseja calcular novamente? (S/N): ");
                char resposta = char.Parse(Console.ReadLine().ToUpper());

            

        }
    }
}
