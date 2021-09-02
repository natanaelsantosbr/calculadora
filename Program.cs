using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma();
        }

        static void Soma()
        {
            Console.Clear();
            System.Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            System.Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            System.Console.WriteLine("");

            float resultado = v1 + v2;
            System.Console.WriteLine("O resultado da soma é: " + resultado);

            // //interpolação de string
            // System.Console.WriteLine($"O resultado da soma é: {resultado}");

            // System.Console.WriteLine($"O resultado da soma é: {v1 + v2}");

            // System.Console.WriteLine($"O resultado da soma é: " + (v1 + v2));
        }
    }
}
