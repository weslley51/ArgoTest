using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteArgo
{
    public class Teste3
    {
        /// <summary>
        /// ex: nome = joao da silva pereira, retorno = Joao da Silva Pereira
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public string NomesComPrimeirasLetrasMaiusculas(string nome)
        {
			return string.Join(" ", nome.Split(' ').Select(x => x.Length > 3 ? char.ToUpper(x[0]) + x.Substring(1) : x));
		}


        /// <summary>
        /// ex: nome = cleber reis pereira, retorno = Cleber Pereira
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public string RemoverNomeDoMeio(string nome)
        {
			var Nomes = nome.Split(' ');
			return NomesComPrimeirasLetrasMaiusculas(string.Join(" ", Nomes.FirstOrDefault(), Nomes.LastOrDefault()));
        }

    }
}
