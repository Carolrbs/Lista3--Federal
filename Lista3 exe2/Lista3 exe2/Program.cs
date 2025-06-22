using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_exe2
{
    internal class Program
    {
        static void Main(string[] args)
        {    double valor1, valor2;
                                                                                                                                                                  
            Console.Write("Digite o primeiro valor: ");
            valor1 = double.Parse(Console.ReadLine());


            Console.Write("Digite o segundo valor: ");
            valor2 = double.Parse(Console.ReadLine());

            while (valor2 <= valor1)
            {
                Console.WriteLine("O segundo valor deve ser maior que o primeiro.");
                Console.Write("Por favor, digite o segundo valor novamente: ");

                valor2 = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Valores inseridos com sucesso!! ");
            Console.WriteLine($"Primeiro valor: {valor1}");
            Console.WriteLine($"Segundo valor: {valor2}");

            Console.ReadKey();
        }
    }
}
