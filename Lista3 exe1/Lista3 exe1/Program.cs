
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_exe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroDigitado = 0;

            while (numeroDigitado <= 0)
            {
                Console.Write("Por favor, digite um número positivo: ");
                numeroDigitado = int.Parse(Console.ReadLine()); ;

                // Verifica se o número digitado é positivo.
                // O loop 'while' vai então verificar a condição novamente e,
                // se o número ainda não for positivo, pedirá de novo.
                if (numeroDigitado <= 0)
                {
                    Console.WriteLine("Erro: O número precisa ser positivo. Tente novamente. ");
                }
            }

            // Quando o loop 'while' termina, significa que 'numeroDigitado' é um valor positivo.
            Console.WriteLine($"Parabéns! Você digitou um número positivo: {numeroDigitado}");

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
