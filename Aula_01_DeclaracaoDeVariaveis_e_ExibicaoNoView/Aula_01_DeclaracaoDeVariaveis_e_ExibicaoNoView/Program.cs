//Aula 01 sobre declaração de variaveis e exibição no terminal.


using System;
using System.Globalization;                 //usado para controle complexo do var tipo double

namespace Aula_01 {
    class FirstProgram {                     //escrito por convenção em PascalCase
        static void Main(string[] args) { 
            bool completo = false;          //tipo boleano retorna verdadeiro ou falso
            char genero = 'F';              //tipo caracter armazena caracter unicode sempre em aspas simples 
            char letra = '\u0041';          //tipo caracter com a codificação unicode iniciando com \u
            sbyte n0 = 25;                  //tipo sbyte ou SByte aceita valores de -128 a 127
            byte n1 = 254;                  //tipo byte aceita apenas valores positivos de  0 a 255
            int n2 = 1000;                  //tipo inteiro aleatorio
            int n3 = 2147483647;            //tipo inteiro, valor maximo que pode ser armazenado
            long n4 = 2147483648L;          //tipo long armazena numeros inteiros maiores que 2147483647
            float n5 = 4.5f;                //tipo float
            double n6 = 4.535784;           //tipo double com controle simples.
            double n7 = 4.854651;           //tipo double com controle complexo
            string nome = "Maria Green";    //tipo string sempre declarando com aspas duplas
            object obj1 = "Alex Brown";     //tipo generico aceita qualquer valor
            object obj2 = 4.5f;             //tipo generico com um valor float

            Console.Write(completo);        //Apenas com Write, Imprimi no terminal sem pular a linha
            Console.WriteLine(genero);      //Utiilizando WriteLine, imprime e ja pula uma linha
            Console.WriteLine(letra);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(n0);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            //Utilizando ToString("F2") controlamos a quantidade de casas decimais depois da virgula      
            Console.WriteLine(n6.ToString("F2"));
            //ignora formatação de região (troca a virgula por ponto)
            Console.WriteLine(n7.ToString("F4", CultureInfo.InvariantCulture));

            //Placeholder(:F2 para configurar a quantidade de casas decimais)
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, n0, n7);

            //Interpolação
            Console.WriteLine($"{nome} tem {n0} anos e tem saldo igual a {n7:F2} reais");

            //Concatenação de strings
            Console.WriteLine(nome + " tem " + n0 + " anos e tem saldo igual a " + n7.ToString("F2", CultureInfo.InvariantCulture) + " reais ");
        }
    }
}
