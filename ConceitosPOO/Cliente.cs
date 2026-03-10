using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosPOO
{
    public class Cliente
    {
        private string _nome;
        private string _cpf;
        public string Nome 
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value.Length != 0)
                    _nome = value;
                else
                    throw new Exception("O nome não pode estar vazio");
            } 
        }
        public string Cpf 
        {
            get => _cpf; 
            set
            {
                if(value.Length == 11)
                    _cpf = value;
                else
                {
                    throw new Exception("O CPF deve ter exatamente 11 dígitos!");
                }
            }
        }
        public Cliente(string nome, string cpf)
        {
            _nome = nome;
            _cpf = cpf;
        }
    }
}
