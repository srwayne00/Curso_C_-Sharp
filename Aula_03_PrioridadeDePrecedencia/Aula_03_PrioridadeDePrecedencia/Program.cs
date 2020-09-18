using System;

namespace Aula_03_PrioridadeDePrecedencia
{
    class Program
    {
        static void Main(string[] args)
        {


            int n1 = 3 + 4 * 2;          //* / % tem prioridade na ordem de precedencia
            int n2 = (3 + 4) * 2;        // pode-se usar os parenteses para indicar a prioridade
            int n3 = 17 % 3;
            double n4 = (double)10 / 8; //usando o cast para indicar que queremos um retorno double ou float
            double n5 = 10.0 / 8.0;      //outra forma é adicionando o .0 depois do valor inteiro.

            double a = 1.0, b = -3.0, c = -4.0;
            double delta = b * b - 4.0 * a * c;  //altenativa poderia ser: double delta = Math.Pow(b, 2.0) -4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a); //Math.Sqrt (Mathemathic.square root ou raiz quadrada de delta)

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(delta);
            Console.WriteLine(x1);
        }
    }
}
