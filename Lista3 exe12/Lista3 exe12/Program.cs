using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_exe12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            do
            {
                Console.Clear();
                int n = 0;

                // Solicita o número de valores
                while (n <= 0 || n >= 20)
                {
                    Console.Write("Digite a quantidade de números (deve ser entre 1 e 19): ");
                    n = Convert.ToInt32(Console.ReadLine());

                    if (n <= 0 || n >= 20)
                    {
                        Console.WriteLine("Quantidade inválida. Tente novamente.");
                    }
                }

                List<int> valores = new List<int>();

                // Coleta os valores
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Digite o valor {i + 1}: ");
                    valores.Add(Convert.ToInt32(Console.ReadLine()));
                }

                // Cálculos
                int maior = valores[0];
                int menor = valores[0];
                int soma = 0;
                int positivos = 0;
                int negativos = 0;

                foreach (var valor in valores)
                {
                    if (valor > maior) maior = valor;
                    if (valor < menor) menor = valor;
                    soma += valor;

                    if (valor > 0) positivos++;
                    else if (valor < 0) negativos++;
                }

                double media = (double)soma / n;
                double porcentagemPositivos = ((double)positivos / n) * 100;
                double porcentagemNegativos = ((double)negativos / n) * 100;

                // Exibe os resultados
                Console.WriteLine("\nResultados:");
                Console.WriteLine($"a. O maior valor: {maior}");
                Console.WriteLine($"b. O menor valor: {menor}");
                Console.WriteLine($"c. A soma dos valores: {soma}");
                Console.WriteLine($"d. A média aritmética dos valores: {media}");
                Console.WriteLine($"e. A porcentagem de valores que são positivos: {porcentagemPositivos}%");
                Console.WriteLine($"f. A porcentagem de valores negativos: {porcentagemNegativos}%");

                // Pergunta se deseja nova execução
                Console.Write("\nDeseja executar o programa novamente? (S/N): ");
            } while (Console.ReadLine().Trim().ToUpper() == "S");
        }

    }
}
