using System;

namespace Aula_04_Vetor_e_Split
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe seu nome completo");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite uma cor");
            string x = Console.ReadLine();
            Console.WriteLine("Digite outra cor");
            string y = Console.ReadLine();
            Console.WriteLine("Digite outra cor");
            string z = Console.ReadLine();

            Console.WriteLine("Olá {0}, suas cores favoritas são {1},{2} e {3}", nome, x, y, z);


            //gravando dados em vetor
            Console.WriteLine("Informe três pratos favoritos");
            string[] v = Console.ReadLine().Split(' ');
            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine(nome + " Seus pratos favoritos são: " + a + ", " + b + " e " + c);


        }
    }
}


