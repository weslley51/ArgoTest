using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteArgo
{
    public class Teste2
    {
        public List<int> CriarLista(int quantidade)
        {
			var Lista = new List<int>();

            for(int i = 0; i < quantidade; i++)
				Lista.Add(i + 1);

			return Lista;
        }

        public List<int> OrdenarLista(params int[] valores)
        {
			return valores.OrderBy(x => x).ToList();
        }
    }
}
