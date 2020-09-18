using System;
using System.Globalization;

namespace Aula_19_dateTime {
    class Program {
        static void Main(string[] args) {

            DateTime d1 = new DateTime(2020, 09, 19);                   //Data sem hora
            DateTime d2 = new DateTime(2020, 09, 19, 10, 42, 05);       //Data com hora  
            DateTime d3 = new DateTime(2020, 09, 19, 10, 42, 05, 500);  //Data com hora e milissegundos

            DateTime d4 = DateTime.Now;                                 //Data atual
            DateTime d5 = DateTime.Today;                               //Data Hoje
            DateTime d6 = DateTime.UtcNow;                              //Data Universal (Grenwitch)

            TimeSpan t1 = TimeSpan.FromDays(1.5);                       //imprime 1 dia e 12 horas

            DateTime d7 = DateTime.Parse("2000-08-15");                 //Conversão de tipo
            DateTime d8 = DateTime.Parse("15-08-2000");                 //Conversão de tipo,

            DateTime d9 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(t1);
        }
    }
}
