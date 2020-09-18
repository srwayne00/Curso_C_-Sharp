using System;
using System.Globalization;

namespace Aula_20_ExpressãoCondicionalTernaria {
    class Program {
        static void Main(string[] args) {

            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto;
            
            //Usando a condicional If Else
            if (preco < 20.0) {
                desconto = preco * 0.1;
            }
            else {
                desconto = preco * 0.5;
            }
            Console.WriteLine(desconto);


            //Usando a condicional ternária
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               //Lê-se se preço menor que 20 ? preço *0.1 :(senão) preço *0.5              
            double desc = (price < 20.0) ? price * 0.1 : price * 0.5;
            Console.WriteLine(desc);
        }
    }
}
