using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercial
{
    public class Produto
    {
        private string _nome;
        private double _preco;
        private int _qte;

        public Produto(string nome, double preco, int qte)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }

            _preco = preco;
            _qte = qte;
        }

        public string Nome
        {
            get { return _nome; }
        }
        public int Quantidade
        {
            get { return _qte; }
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _qte;
        }

        public double RemoverProduto(int qte)
        {
            return _qte -= qte;
        }

        public override string ToString()
        {
            return "\nNome do Produto: "
                + Nome
                + "\nQuantidade do produto:  "
                + Quantidade
                + " unidades"
                + "\nValor total do estoque:  "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)
                + " Reais";
        }

    }
}
