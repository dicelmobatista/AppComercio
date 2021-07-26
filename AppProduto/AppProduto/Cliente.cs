using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercial
{
    public class Cliente
    {
        private string _nome;
        private string _telefone;

        public Produto produto;


        public Cliente(string nome, string telefone)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }

            if (telefone != null && telefone.Length > 8)
            {
                _telefone = telefone;
            }
        }

        public string Nome
        {
            get { return _nome; }
          
        }
        public string Telefone
        {
            get { return _telefone; }
        }
    }
}
