using System;

namespace Aula_02_ConvercaoImplicita_e_Explicita
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversão implicita de float para double
            float x = 4.5f;
            double y = x;
            Console.WriteLine(y);

            //Conversão explicita de double para float
            double a = 5.1;
            float b = (float)a; //inserimos o cast (float) antes do valor da variavel, senão a mesma apresentará erro
            Console.WriteLine(b);

            //Conversão explicita de double para inteiro
            double c = 6.3;
            int d = (int)c;
            Console.WriteLine(c);

            //usando o cast para converter a variavel inteira em double e obter o resultado correto.
            int f = 5;
            int g = 2;
            double resultado = (double)f / g;
            Console.WriteLine(resultado);


        }
    }
}



