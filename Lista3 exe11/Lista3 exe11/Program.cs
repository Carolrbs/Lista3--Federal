using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_exe11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool nValido = false;

            do
            {
                Console.Write("Digite a quantidade de valores (N), que deve ser positiva e menor que 20: ");
                string entradaN = Console.ReadLine();

                if (int.TryParse(entradaN, out n))
                {
                    if (n > 0 && n < 20)
                    {
                        nValido = true;
                    }
                    else
                    {
                        Console.WriteLine("ERRO: N deve ser um número positivo e menor que 20. Tente novamente.");
                    }
                }
                else
                {
                    Console.WriteLine("ERRO: Entrada inválida. Por favor, digite um número inteiro para N.");
                }
            } while (!nValido);

            int[] valores = new int[n];

            int soma = 0;
            int maiorValor = int.MinValue;
            int menorValor = int.MaxValue;
            int contadorPositivos = 0;
            int contadorNegativos = 0;

            Console.WriteLine($"\nPor favor, digite os {n} valores (podem ser positivos, negativos ou zero):");

            for (int i = 0; i < n; i++)
            {
                int valorDigitado;
                bool valorValido = false;

                do
                {
                    Console.Write($"Digite o {i + 1}º valor: ");
                    string entradaValor = Console.ReadLine();

                    if (int.TryParse(entradaValor, out valorDigitado))
                    {
                        valorValido = true;
                    }
                    else
                    {
                        Console.WriteLine("ERRO: Entrada inválida. Por favor, digite um número inteiro.");
                    }
                } while (!valorValido);

                valores[i] = valorDigitado;
                soma += valorDigitado;

                if (valorDigitado > maiorValor)
                {
                    maiorValor = valorDigitado;
                }

                if (valorDigitado < menorValor)
                {
                    menorValor = valorDigitado;
                }

                if (valorDigitado > 0)
                {
                    contadorPositivos++;
                }
                else if (valorDigitado < 0)
                {
                    contadorNegativos++;
                }
            }
            Console.WriteLine($"a. O maior valor digitado foi: {maiorValor}");

            Console.WriteLine($"b. O menor valor digitado foi: {menorValor}");

            Console.WriteLine($"c. A soma dos valores é: {soma}");

            double media = (double)soma / n;
            Console.WriteLine($"d. A média aritmética dos valores é: {media:F2}");

            double porcentagemPositivos = (double)contadorPositivos / n * 100;
            Console.WriteLine($"e. Porcentagem de valores positivos: {porcentagemPositivos:F2}%");

            double porcentagemNegativos = (double)contadorNegativos / n * 100;
            Console.WriteLine($"f. Porcentagem de valores negativos: {porcentagemNegativos:F2}%");

            Console.WriteLine("\nPressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}
