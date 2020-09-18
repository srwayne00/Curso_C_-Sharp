﻿using System;

namespace Aula_06_Calculo_Maior_e_Menor {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite três números inteiros: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);
            Console.WriteLine("Maior = "+ resultado);
        }

        //declaração da uma nova função
        static int Maior(int a, int b, int c) {
            int m;
            if (a > b && a > c) { m = a;}
            else if (b > c) { m = b; }
            else { m = c;}
            return m;
        }
    }
}