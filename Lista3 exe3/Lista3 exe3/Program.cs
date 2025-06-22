using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_exe3
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            string sexo;

            // Loop para garantir que a entrada seja 'F' ou 'M'
            do
            {
                Console.WriteLine("Digite o sexo (F para Feminino, M para Masculino):");
                sexo = Console.ReadLine().ToUpper();

                if (sexo != "F" && sexo != "M")
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite 'F' ou 'M'.");
                }

            } while (sexo != "F" && sexo != "M"); // Continua o loop enquanto a entrada for inválida

            Console.WriteLine($"Sexo digitado: {sexo}");
        }
    }
}
