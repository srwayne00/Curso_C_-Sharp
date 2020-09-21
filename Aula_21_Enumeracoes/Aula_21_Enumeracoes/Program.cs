/*
Enumeração ou enumerado é um tipo especial que serve para especificar de forma literal um conjunto de constantes relacionadas
Palavra chave em c# enum // em UML  <<enum>>
Vantagem: Melhor semantica, codigo mais legivel e auxiliado pelo compilador
*/

using Aula_21_Enumeracoes.Entities;
using Aula_21_Enumeracoes.Entities.Enums;
using System;

namespace Aula_21_Enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayments
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayments.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}
