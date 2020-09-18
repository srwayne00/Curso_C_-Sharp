using System;
using System.Collections.Generic;

namespace Aula_16_List {
    class Program {
        static void Main(string[] args) {

            List<string> list = new List<string>();         //declaração de uma lista

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");                        //adiciona o Marco na 2° posição da lista
            
            foreach (string obj in list) { Console.WriteLine(obj); }
            Console.WriteLine("List count: " + list.Count); //conta os elementos na lista
        
            string s1 = list.Find(x => x[0] == 'A');        //usando a expressão lambda é possivel buscar a informação
            Console.WriteLine("First 'A': " + s1);          //do primeiro nome que começa com 'A'.

            string s2 = list.FindLast(x => x[0] == 'A');    //usando a expressão lambda é possivel buscar a informação
            Console.WriteLine("Last 'A' " + s2);            //do ultimo nome que começa com 'A'.

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position " + pos1);    //busca a 1° posição de quem começa com a letra A

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position " + pos2);    //busca a ultima posição de quem começa com a letra A

            List<string> list2 = list.FindAll(x => x.Length == 5); //Filtra apenas os nomes com 5 letras na lista
            foreach (string obj in list2) { Console.WriteLine(obj); }

            list.Remove("Alex");                           //remove um nome especifico da lista
            foreach (string obj in list) { Console.WriteLine(obj); }

            list.RemoveAll(x => x[0] == 'M');              //remover todos com m na lista
            foreach (string obj in list) { Console.WriteLine(obj); }

            list.RemoveAt(1);                              //remove quem estiver na posição 1 da lista
            foreach (string obj in list) { Console.WriteLine(obj); }

            list.RemoveRange(2,2);                         //remove que 2 nomes apartir da posição 2
            foreach (string obj in list) { Console.WriteLine(obj); }
        }
    }
}
