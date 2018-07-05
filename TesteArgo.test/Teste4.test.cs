using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteArgo.test
{
    [TestClass]
    public class Teste4Test
    {
        Teste4 ClasseTeste = new Teste4();

        [TestMethod]
        public void Teste4_ListarFilmes()
        {
            var Resultado = ClasseTeste.ListarFilmes("batman");

            Assert.IsNotNull(Resultado);
            Assert.IsTrue(Resultado.Count > 0);
        }


        [TestMethod]
        public void Teste4_ListarPorId()
        {
            var Resultado = ClasseTeste.ListarPorId("tt0372784");

            Assert.IsNotNull(Resultado);
            Assert.IsTrue(Resultado.Titulo.ToLower().Contains("batman"));
        }
    }
}
