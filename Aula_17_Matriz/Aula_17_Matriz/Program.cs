using System;

namespace Aula_17_Matriz {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n]; //Declaração de uma matriz 

            for (int i = 0; i < n; i++) {      //for para percorrer a linha
                string[] values = Console.ReadLine().Split(' '); //Le a linha inteira e guardando cada espaço num vetor "values"

                for (int j = 0; j < n; j++) {       //for para percorrer a coluna
                    mat[i,j] = int.Parse(values[j]); //matriz na posição linha i coluna j vai receber o values da posição j
                }
            }

            Console.WriteLine("Main Diagonal: ");
            for(int i = 0; i < n; i++) {
                Console.Write(mat[i,i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++) {
                for(int j = 0; j < n; j++) {
                    if (mat[i,j] < 0) {
                        count++;
                    }
                }

            }
            Console.WriteLine("Negative number: " + count);
        }
    }
}
