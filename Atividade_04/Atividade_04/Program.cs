using System;
using System.Globalization;

namespace Atividade_04 {
    class Program {
        static void Main(string[] args) {

            Colaborador f1 = new Colaborador();
            Colaborador f2 = new Colaborador();

            //Ler o nome e salario de 2 funcionarios(Carlos Silva 6300.00 e Ana Marques 6700.00)
            Console.WriteLine("Informe o nome do primeiro funcionario");
            f1.Funcionario = Console.ReadLine();
            Console.WriteLine("Informe o salario do primeiro funcionario");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Clear();

            Console.WriteLine("Informe o nome do segundo funcionario");
            f2.Funcionario = Console.ReadLine();
            Console.WriteLine("Informe o salario do segundo funcionario");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Clear();            

            //Mostrar o salario medio dos funcionarios 6500.00
            double salarioMedio = f1.Salario + f2.Salario / 2.0;
            Console.WriteLine("Salário médio dos funcionarios é: " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
