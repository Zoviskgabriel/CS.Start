using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            int r;
            Console.WriteLine("Qual a idade do primeiro aluno?");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a idade do segundo aluno?");
            n2 = int.Parse(Console.ReadLine());

            r = n1 + n2;


            if (n1 > n2)
            {
                Console.WriteLine("O primeiro aluno é mais velho que o segundo aluno");
            }
            if (n1 < n2)
            {
                Console.WriteLine("O segundo aluno é mais velho que o primeiro aluno");
            }
            if (n1 == n2)
            {
                Console.WriteLine("Os dois alunos têm a mesma idade");
            }
        }
    }
}