using System;
using System.Data;
using System.Globalization;

namespace Atividade_02 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Informe seu nome completo: ");
            string completeName = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Quantos quartos tem a sua casa?");
            int qtdQuartos = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Entre com o preço do produto");
            double vlProdutos = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Clear();

            Console.WriteLine("Informe seu ultimo nome, idade e altura");
            string[] vet = Console.ReadLine().Split(' ');
                        
            string lastName = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);
            Console.Clear();

            Console.WriteLine(completeName);
            Console.WriteLine(qtdQuartos);
            Console.WriteLine(vlProdutos.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));   
        }
    }
}
