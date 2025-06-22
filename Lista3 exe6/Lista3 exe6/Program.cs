using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_exe6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x; // O número principal para a tabuada
            int a; // O início do intervalo
            int b; // O fim do intervalo

         

            do // "Do-While" - "Faça isso... enquanto a condição for verdadeira"
            {
                Console.WriteLine("Por favor, digite um número POSITIVO para a tabuada (X):");
                
                while (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Entrada inválida! Por favor, digite um NÚMERO inteiro.");
                    Console.WriteLine("Digite um número POSITIVO para a tabuada (X):");
                }

                if (x <= 0) // Se o número for menor ou igual a zero...
                {
                    Console.WriteLine("Número inválido! Por favor, digite um número que seja POSITIVO.");
                }
            } while (x <= 0); // ...continue repetindo enquanto X for menor ou igual a zero.

            Console.WriteLine("\nAgora, digite o valor INICIAL do intervalo para a tabuada (A):");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Entrada inválida! Por favor, digite um NÚMERO inteiro.");
                Console.WriteLine("Digite o valor INICIAL do intervalo para a tabuada (A):");
            }

            do // Novamente, um "Do-While" para garantir que B seja maior que A
            {
                Console.WriteLine("\nFinalmente, digite o valor FINAL do intervalo para a tabuada (B):");
                while (!int.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Entrada inválida! Por favor, digite um NÚMERO inteiro.");
                    Console.WriteLine("Digite o valor FINAL do intervalo para a tabuada (B):");
                }

                if (b <= a) // Se B for menor ou igual a A...
                {
                    Console.WriteLine("ATENÇÃO: O valor FINAL (B) precisa ser MAIOR que o valor INICIAL (A).");
                    Console.WriteLine("Por favor, digite B novamente.");
                }
            } while (b <= a); // ...continue repetindo enquanto B for menor ou igual a A.

            // --- Parte 4: Exibir a tabuada de X de forma decrescente (de B até A) ---

            Console.WriteLine($"\n--- Tabuada do {x} (do {b} até o {a}) ---"); // Exibe um cabeçalho

            for (int i = b; i >= a; i--) // int i = b: Começa a contar de B
                                         // i >= a: Continua enquanto i for maior ou igual a A
                                         // i--: Diminui 1 do i a cada repetição
            {
                int resultado = x * i; // multiplica
                                       
                Console.WriteLine($"{x} x {i} = {resultado}");
            }

            Console.WriteLine("\nTabuada concluída! Pressione qualquer tecla para sair.");
            Console.ReadKey(); 
        }
    }
    }
}