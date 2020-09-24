using System;
using System.Collections.Generic;

namespace Aula_26_HashSet_SortedSet_Generic_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            SortedSet<int> a = new SortedSet<int>() { 4, 2, 0, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 1, 9, 5, 7 ,3, 8, 10 };
            Console.WriteLine("All declared in a");
            PrintCollection(a);                                              //Print function
            Console.WriteLine("All declared in b");
            PrintCollection(b);
            Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");

            //Union of conjuncts
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            Console.WriteLine("Union of all declared in a and b");
            PrintCollection(c);
            Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");

            //Intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            Console.WriteLine("Only the equal declared in a and b");
            PrintCollection(d);
            Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");

            //Difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            Console.WriteLine("Only difference of declared into a and b");
            PrintCollection(e);
            Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");

            HashSet<string> set = new HashSet<string>();                    //HashSet function
            set.Add("Maria");
            set.Add("Alex");
            Console.WriteLine("Return true or false if constain or not the string declared");
            Console.WriteLine(set.Contains("Maria"));
            Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");
        }
        static void PrintCollection<T>(IEnumerable<T> collection)   //Function Generic
        {
            foreach(T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
