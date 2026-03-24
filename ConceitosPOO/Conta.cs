using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosPOO
{
    public class Conta
    {
        private long _numero;
        private decimal _saldo;

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
