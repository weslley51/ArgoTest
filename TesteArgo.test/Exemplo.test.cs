using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Threading.Tasks;

namespace TesteArgo.test
{
    [TestClass]
    public class ExemploTeste
    {
		[TestMethod]
		public void Exemplo_Metodo()
        {
			Assert.IsTrue(new Exemplo().MetodoExemplo());
        }
    }
}
