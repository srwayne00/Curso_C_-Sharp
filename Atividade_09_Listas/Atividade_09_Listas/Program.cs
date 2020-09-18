using System;
using System.Collections.Generic;
using System.Globalization;

namespace Atividade_09_Listas {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Quantos colaboradores você tem registrado? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for(int i = 1; i <= n; i++) {
                Console.WriteLine("Colaborador #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }
            Console.WriteLine("Entre com o ID do colaborador que terá aumento de salario: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);
            if(emp != null) {
                Console.Write("Entre com a porcentagem: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            } 
            else {
                Console.WriteLine("Este Id não existe!");
            }
            
            Console.WriteLine();
            Console.WriteLine("Atualizado a lista de colaboradores: ");
            foreach (Employee obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}
