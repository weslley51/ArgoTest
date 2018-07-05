using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteArgo.test
{
    [TestClass]
    public class Teste1Teste
    {
        Teste1 ClasseTeste = new Teste1();

        [TestMethod]
        public void Teste1_Soma()
        {
            Assert.AreEqual(6, ClasseTeste.Somar(1, 5));
        }

        [TestMethod]
        public void Teste1_Subtrair()
        {
            Assert.AreEqual(2, ClasseTeste.Subtrair(5, 3));
            Assert.AreEqual(3, ClasseTeste.Subtrair(10, 7));
        }

        [TestMethod]
        public void Teste1_Media()
        {
            Assert.AreEqual(30, ClasseTeste.Media(50, 20, 20));
            Assert.AreEqual(10, ClasseTeste.Media(10, 10, 10));
            Assert.AreEqual(50, ClasseTeste.Media(40, 50, 110,20,20,60));
        }

        [TestMethod]
        public void Teste1_CalcularIdade()
        {
            Assert.AreEqual(27, ClasseTeste.CalcularIdade(1990, 9, 22));

			// Observação:
			// Teste abaixo estava como 20, foi alterado para 21 visto que o valor que ele deveria retornar era, de fato, 21.
			// Acredito que o teste foi feito antes do mês 5, logo era 20, porém como agora estamos no mês 6 o correto é 21
			Assert.AreEqual(21, ClasseTeste.CalcularIdade(1997, 5, 12));
        }
    }
}
