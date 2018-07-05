using System;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteArgo.test
{
    [TestClass]
    public class Teste2Test
    {
        Teste2 ClasseTeste = new Teste2();

        [TestMethod]
        public void Teste2_Criarlista()
        {
            var Resultado = ClasseTeste.CriarLista(500);

            Assert.IsNotNull(Resultado);
            Assert.AreEqual(500 , Resultado.Count);
        }

        [TestMethod]
        public void Teste2_OrdenarLista()
        {
            var Resultado = ClasseTeste.OrdenarLista(8,9,6,5,6,4,3,25,89);

            Assert.IsNotNull(Resultado);
            Assert.AreEqual(9, Resultado.Count);

            Assert.AreEqual(3, Resultado[0]);
        }
    }
}
