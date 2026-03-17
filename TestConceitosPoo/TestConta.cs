using ConceitosPOO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestConceitosPoo
{
    [TestClass]
    public class TestConta
    {
        [TestMethod]
        public void TestDeposito()
        {
            //cenário
            decimal saldoInicial = 1000;
            decimal valorDeposito = 500;
            decimal saldoEsperado = 1500;
            Conta conta = new Conta(1111, saldoInicial);

            //ação
            conta.Deposito(valorDeposito);

            //verificação
            Assert.AreEqual(saldoEsperado, conta.Saldo);
        }
    }
}
