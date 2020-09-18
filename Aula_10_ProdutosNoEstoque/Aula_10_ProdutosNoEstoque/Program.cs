using System;
using System.Globalization;

namespace Aula_10_ProdutosNoEstoque {
    class Program {
        static void Main(string[] args) {
                                   
            //Ler e mostrar os dados do produto (nome, preço, qtd no estoque, vl total no estoque)
            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);//Utilizando construtor

            Console.WriteLine();
            Console.WriteLine("Dados do produto:" + p);

            //Realizar uma entrada no estoque e mostrar os dados atualizados
            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser adicionado ao estoque");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            //Realizar um saida no estoque e mostrar os dados atualizados
            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser removido do estoque");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
