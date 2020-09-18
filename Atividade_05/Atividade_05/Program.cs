using System;
using System.Globalization;

namespace Atividade_05 {
    class Program {
        static void Main(string[] args) {

            Retangulo ret = new Retangulo();

            //Entre com a largura e altura do retangulo
            Console.WriteLine("Entre com a largura e altura do retângulo:");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Mostrar na tela o valor da area, perimetro e diagonal.
            Console.WriteLine("Area = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

