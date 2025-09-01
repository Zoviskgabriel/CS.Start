using System;

class Program
{
    static void Main()
    {
        //Inicio altura da pirâmide
        int altura = 5;

        //Loop while para criar a pirâmide
        int linha = 1; //Primeira linha
        while (linha <= altura)
        {
            //Imprimi espaços
            for (int espacos = 0; espacos < altura - linha; espacos++)
            {
                Console.Write(" ");
            }

            //Imprimi os caracteres 
            for (int caractere = 0; caractere < (2 * linha - 1); caractere++)
            {
                Console.Write("*");
            }

            // Nova linha depois de cada linha da pirâmide
            Console.WriteLine();

            //Passar para a próxima linha
            linha++;
        }
    }
}

