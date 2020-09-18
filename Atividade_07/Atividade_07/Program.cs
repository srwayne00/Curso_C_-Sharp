using System;
using System.Globalization;

namespace Atividade_07 {
    class Program {
        static void Main(string[] args) {
                        
            ContaBancaria conta;

            Console.WriteLine("Enter com o numero da conta");       //Entre com o numero da conta (8532)
            int numero = int.Parse(Console.ReadLine());
  
            Console.WriteLine("Entre com o titular da conta: ");    //Entre com o titular da conta (Alex Green)
            string titular = Console.ReadLine();

            Console.Write("Haverá deposito inicial (S/N)? ");      //Haverá deposito inicial (s/n)?  (s)
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S') {
                Console.Write("Entre com o valor do depoisto inicial: ");   //Entre o valor do deposito inicial: (200.00)
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Console.WriteLine("Dados da conta: ");              //Conta 8532, Titula Alex Green, Saldo: $ 200.00
            Console.WriteLine(conta);                           //Exibir Dados da conta:
            Console.Clear();

            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Console.Write("Entre com um valor para deposito: ");//Entre com um valor para deposito: (200.00)
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.Clear();
            Console.WriteLine("Dados da conta atualizados: ");  //Dados da conta atualizados:
            Console.WriteLine(conta);                           //Conta 8532, Titula Alex Green, Saldo: $ 700.00

            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Console.Write("Entre com um valor para saque: ");   //Entre com um para saque: (698.00)
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.Clear();
            Console.WriteLine("Dados da conta atualizados: ");  //Dados da conta atualizados:
            Console.WriteLine(conta);                           //Conta 8532, Titula Alex Green, Saldo: $ (-3.00)
        }
    }
}






