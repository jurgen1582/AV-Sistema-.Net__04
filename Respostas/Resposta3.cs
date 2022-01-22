using System;
using System.Collections.Generic;
using System.Text;

namespace Respostas
{
    class Resposta3
    {
        static void Main(string[] args)
        {
            int a;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Algoritimos dos retângulos");
                Console.WriteLine("Insira a Variavel A: ");
                a = int.Parse(Console.ReadLine());
                if (a == 0)
                    break;
                Console.WriteLine();
                Console.WriteLine("Insira a Variavel B: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Insira a Variavel C: ");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if ((a < b + c) && (b < a + c) && (c < a + b))
                {
                    if ((a == b) && (b == c))
                        Console.WriteLine("Triângulo Equilátero");
                    else if ((a == b) || (b == c) || (a == c))
                        Console.WriteLine("Triângulo Isósceles");
                    else
                        Console.WriteLine("Triângulo Escaleno");
                }
                else
                    Console.WriteLine("Não e possível formar um triângulo");

            } while (a != 0);

            // Letra A: Não e possível formar um triângulo;
            // Letra B: Triângulo Escaleno;
            // Letra C: Não e possível formar um triângulo;
            // Letra D: Triângulo Equilátero;
            // Letra E: Triângulo Isósceles;

        }

    }
}
