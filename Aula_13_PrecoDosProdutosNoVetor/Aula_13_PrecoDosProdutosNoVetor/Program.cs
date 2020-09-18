using System;
using System.Globalization;
using System.Reflection;

namespace Aula_13_PrecoDosProdutosNoVetor {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com a quantidade de objetos para calcular o preço medio:");  
            int n = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Informe o produto seguido do preço");
            Product[] vect = new Product[n];
            for(int i = 0; i < n; i++) {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
            }

            Console.Clear();
            double sum = 0.0;
            for(int i = 0; i < n; i++) {
                sum += vect[i].Price;
            }

            double avg = sum / n;
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("Preço medio dos produtos é  " + avg.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("******************************************************************************************");
        }
    }
}
