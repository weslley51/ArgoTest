using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteArgo.test
{
    [TestClass]
    public class Teste3Test
    {
        Teste3 ClasseTeste = new Teste3();

        [TestMethod]
        public void Teste3_NomesComPrimeirasLetrasMaiusculas()
        {
            var Resultado = ClasseTeste.NomesComPrimeirasLetrasMaiusculas("joao da silva pereira");

            Assert.IsNotNull(Resultado);
            Assert.AreEqual("Joao da Silva Pereira", Resultado);
        }


        [TestMethod]
        public void Teste3_RemoverNomeDoMeio()
        {
            var Resultado = ClasseTeste.RemoverNomeDoMeio("cleber reis pereira");

            Assert.IsNotNull(Resultado);
            Assert.AreEqual("Cleber Pereira", Resultado);

            Resultado = ClasseTeste.RemoverNomeDoMeio("armando pompilio pomposo reis pereira");

            Assert.IsNotNull(Resultado);
            Assert.AreEqual("Armando Pereira", Resultado);
        }
    }
}
