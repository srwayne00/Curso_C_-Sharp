using Aula_25_IComparable.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace Aula_25_IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Temp\in.txt";                     //Arquivo na pasta Temp

            try
            {
                using (StreamReader sr = File.OpenText(path))   //Abrir o arquivo usando StreamReader
                {
                    List<Employee> list = new List<Employee>(); //Cria a lista
                    while (!sr.EndOfStream)                     //Percorre o aquivo, enquanto nao for o final 
                    {
                        list.Add(new Employee(sr.ReadLine()));  //adiciona um item a lista.
                    }
                    list.Sort();                                //Ordenar a lista
                    foreach (Employee emp in list)              //Para cada string na lista
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException e)                               //caso apresente erro informe os dados abaixo
            {
                Console.WriteLine("An error occurred");         //indica que houve um erro
                Console.WriteLine(e.Message);                   //tipo de erro 
            }
        }
    }
}
