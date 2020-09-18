using System;
using System.Globalization;

namespace Aula_12_Vetores {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com a quantidade de entrevistados: ");
            int n = int.Parse(Console.ReadLine());  //declaração da variavel n

            Console.WriteLine("Entre com as respectivas alturas");
            double[] vect = new double[n];  //declaração do vetor
            for (int i = 0; i < n; i++) {   //FOR para incrementar o vetor nas posição i
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;               //declaração da variavel sum recebendo valor inicial de 0.0
            for(int i = 0; i < n; i++) {    //for para cobrir todas as posições do vetor
                sum += vect[i];             //soma de todos as posições do vetor na variavel sum
            }

            double avg = sum / n;           //declaração da variavel avg junto com a formula de divisão por n
            Console.WriteLine("Altura media dos entrevistados é = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
