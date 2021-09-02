﻿using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            System.Console.WriteLine("O que deseja fazer? ");
            System.Console.WriteLine("1 - Soma");
            System.Console.WriteLine("2 - Substração");
            System.Console.WriteLine("3 - Divisao");
            System.Console.WriteLine("4 - Multiplicação");
            System.Console.WriteLine("5 - Sair");
            System.Console.WriteLine("----");
            System.Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Substracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
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
            Console.ReadKey();
            Menu();
        }
        static void Substracao()
        {
            Console.Clear();
            System.Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            System.Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            System.Console.WriteLine("");

            float resultado = v1 - v2;
            System.Console.WriteLine("O resultado da soma é: " + resultado);

            // //interpolação de string
            // System.Console.WriteLine($"O resultado da soma é: {resultado}");

            // System.Console.WriteLine($"O resultado da soma é: {v1 + v2}");

            // System.Console.WriteLine($"O resultado da soma é: " + (v1 + v2));
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            System.Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            System.Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            System.Console.WriteLine("");

            float resultado = v1 / v2;
            System.Console.WriteLine("O resultado da soma é: " + resultado);

            // //interpolação de string
            // System.Console.WriteLine($"O resultado da soma é: {resultado}");

            // System.Console.WriteLine($"O resultado da soma é: {v1 + v2}");

            // System.Console.WriteLine($"O resultado da soma é: " + (v1 + v2));
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            System.Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            System.Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            System.Console.WriteLine("");

            float resultado = v1 * v2;
            System.Console.WriteLine("O resultado da soma é: " + resultado);

            // //interpolação de string
            // System.Console.WriteLine($"O resultado da soma é: {resultado}");

            // System.Console.WriteLine($"O resultado da soma é: {v1 + v2}");

            // System.Console.WriteLine($"O resultado da soma é: " + (v1 + v2));
            Console.ReadKey();
            Menu();
        }
    }
}
