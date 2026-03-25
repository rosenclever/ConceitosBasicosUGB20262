using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosPOO
{
    public class Conta
    {
        /* 
         * efetue o relacionamento de conta com agencia
         * faça com que uma conta possa ser criada ou 
         * informando o numero da  conta e seu saldo ou
         * informando o numero da conta, seu saldo e seu titular.
         * toda conta deve obrigatoriamente pertencer a uma agencia.
         */
        private long _numero;
        private decimal _saldo;
        private Cliente _titular;

        private Agencia _agencia;

        public Agencia Agencia
        {
            get { return _agencia; }
            set { _agencia = value; }
        }


        public Cliente Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }

        public Conta(long numero, decimal saldo)
        {
            _numero = numero;
            _saldo = saldo;
        }

        public long Numero {
            get => _numero;
            private set
            {
                _numero = value;
            } 
        }

        public decimal Saldo
        {
            get => _saldo;
            private set => _saldo = value;

        }

        public void Deposito(decimal valor)
        {
            if (valor > 0)
                this.Saldo += valor; //saldo = saldo + valor;
            else
                throw new ArgumentException("O valor tem que ser positivo");
        }

        public void Saque(decimal valor) 
        {
            if (valor > 0)
                this.Saldo -= valor; //saldo = saldo + valor;
            else
                throw new ArgumentException("O valor tem que ser positivo");
        }

        public void Transferencia(Conta contaDestino, decimal valorTransferencia)
        {
            if (valorTransferencia <= 0) throw new ArgumentException("O valor a ser transferido deve ser superior a zero.");
            this.Saque(valorTransferencia);
            contaDestino.Deposito(valorTransferencia);
        }
    }
}
