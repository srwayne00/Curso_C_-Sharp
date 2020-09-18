using System.Globalization;

namespace Aula_11_Encapsulamento {
    class Produto {
        private string _nome; //atributo privativo não permite a auto propertie
        public double Preco { get; private set;}   //auto properties
        public int Quantidade { get; private set; } //auto properties

        public Produto() { }   //construtor

        public Produto(string nome, double preco, int quantidade) { //construtor
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        public string Nome {                //Propriedades customizadas
            get { return _nome; }
            set { if (value != null && value.Length > 1) { _nome = value;}
            }
        }
        
        public double ValorTotalEmEstoque() {return Preco * Quantidade;}    //metodo de calculo total
        public void AdicionarProdutos(int quantidade) {Quantidade += quantidade;} //metodo de adicionar produto
        public void RemoverProdutos(int quantidade) {Quantidade -= quantidade; } //metodo de remover produto
        public override string ToString() { return _nome  //metodo TO String
                + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "   + Quantidade   + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
