using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp7.Model
{
    internal class ListaProduto
    {
        List<Produto> produtos = new List<Produto>();
        private int Codigo { get; set; }
        private string Nome { get; set; }

        private double Preco { get; set; }

        public void adicionarProduto(int codigo, string nome, double preco) {

            Produto novoProduto = new Produto
            {
                this.Codigo = codigo;
            this.Nome = nome;
            this.Preco = preco;
        };
            
            
        }


        

    }
}
