using System;
using System.Runtime.Serialization;

namespace Aula_08_FOR {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Quantos números inteiros você vai digitar?");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= N; i++) {
                Console.WriteLine("Valor #{0}: ",i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine("soma = " + soma);
        }
    }
}
