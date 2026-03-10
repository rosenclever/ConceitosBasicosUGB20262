using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosPOO
{
    public class Agencia
    {
        private int _numero;
        private string _nome;
        private string _telefone;
        public string Nome { 
            get => _nome;
            set
            {
                _nome = value;
            } 
        }
        public string Telefone { 
            get => _telefone; 
            set
            {
                _telefone = value;
            }
                 
        }
    }
}
