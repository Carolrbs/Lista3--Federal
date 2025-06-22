using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_exe5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor;
            string input;

            do
            {
                Console.WriteLine("Digite um valor positivo para ver a tabuada:");
                input = Console.ReadLine();

                if (!int.TryParse(input, out valor) || valor <= 0)
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro positivo.");
                }

            } while (valor <= 0); // Continua enquanto o valor não for positivo

            Console.WriteLine($"Tabuada do {valor}:");

            int multiplicador = 1;
            // Geração da tabuada de 1 a 10 usando while
            while (multiplicador <= 10)
            {
                Console.WriteLine($"{valor} x {multiplicador} = {valor * multiplicador}");
                multiplicador = multiplicador + 1; // Incrementa o multiplicador

            }
        }
}
