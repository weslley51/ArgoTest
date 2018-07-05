using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteArgo.Entities
{
	/// <summary>
	/// Classe criada para pegar os dados da requisição na API
	/// </summary>
	public class Movie : Dominio
	{
		public string Year { get; set; }
		public string Title { get; set; }
		public string Poster { get; set; }
		public string imdbID { get; set; }
	}
}
