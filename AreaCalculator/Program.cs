using System;

namespace AreaCalculator
{
    internal class Program
    {
        // Variáveis 
        static double raio = 0;
        static double baseTriangulo = 0;
        static double altura = 0;
        static double comprimento = 0;
        static double largura = 0;
        static string nome = "";

        // Funções Print 
        static void Print(string value)
        {
            Console.WriteLine(value);
        }

        static void Print(double value)
        {
            Console.WriteLine(value);
        }

        // Cálculo do círculo
        static double AreadoCirculo(double value)
        {
            return Math.Pow(value, 2) * Math.PI;
        }

        // Cálculo do triângulo
        static double AreadoTriangulo(double b, double h)
        {
            return (b * h) / 2;
        }

        // Cálculo do retângulo
        static double AreadoRetangulo(double c, double l)
        {
            return c * l;
        }

        // Menu
        static void Main(string[] args)
        {
            // Entrada nome:
            Print("Olá! Qual é o seu nome?");
            nome = Console.ReadLine();
            Print($"Olá, {nome}! Vamos calcular a área de uma figura.");

            // Seleção
            Print("Digite 1 para Círculo");
            Print("Digite 2 para Triângulo");
            Print("Digite 3 para Retângulo");

            string escolha = Console.ReadLine();


            // If e else:
            if (escolha == "1")
            {
                Print("Insira o raio do círculo:");
                raio = double.Parse(Console.ReadLine());
                double resp = AreadoCirculo(raio);
                Print($"Área do círculo, {nome}:");
                Print(resp);
            }
            else if (escolha == "2")
            {
                Print("Insira a base do triângulo:");
                baseTriangulo = double.Parse(Console.ReadLine());

                Print("Insira a altura do triângulo:");
                altura = double.Parse(Console.ReadLine());

                double resp = AreadoTriangulo(baseTriangulo, altura);
                Print($"Área do triângulo, {nome}:");
                Print(resp);
            }
            else if (escolha == "3")
            {
                Print("Insira o comprimento do retângulo:");
                comprimento = double.Parse(Console.ReadLine());

                Print("Insira a largura do retângulo:");
                largura = double.Parse(Console.ReadLine());

                double resp = AreadoRetangulo(comprimento, largura);
                Print($"Área do retângulo, {nome}:");
                Print(resp);
            }
            else
            {
                Print("Opção inválida. Execute o programa novamente.");
            }

            // Saida
            Print($"\nObrigado por usar o Calculador de Áreas, {nome}!");
        }
    }
}