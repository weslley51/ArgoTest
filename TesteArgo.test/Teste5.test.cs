using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteArgo.test
{
    [TestClass]
    public class Teste5Test
    {
        Teste5 ClasseTeste = new Teste5();

        [TestMethod]
        public void Teste4_ListarFilmes()
        {
            var Resultado = ClasseTeste.ListarDestino();

            Assert.IsNotNull(Resultado);
            Assert.IsTrue(Resultado.Count > 0);
        }


        [TestMethod]
        public void Teste4_ListarPorId()
        {
            var Resultado = ClasseTeste.BuscarPorId(1);

            Assert.IsNotNull(Resultado);            
        }
    }
}
