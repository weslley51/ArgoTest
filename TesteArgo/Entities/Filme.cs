using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteArgo.Entities
{
	public class Filme : Dominio
	{
		/// <summary>
		/// Title
		/// </summary>
		public string Titulo { get; set; }

		/// <summary>
		/// Year
		/// </summary>
		public int? Ano { get; set; }

		/// <summary>
		/// imdbID
		/// </summary>
		public string ID { get; set; }

		/// <summary>
		/// Poster
		/// </summary>
		public string Imagem { get; set; }

		public Filme() {}

		public Filme(Movie Movie)
		{
			// Observação
			// Retorno da API é uma string, visto que pode retornar um intervalo de tempo como no registro de título:
			// Batman: The Animated Series no qual consta o valor de 1992–1995, não sabia se deveria alterar a classe ou não,
			// portanto utilizei apenas a primeira data como base
			Ano = Convert.ToInt32(Movie.Year.Split('–').FirstOrDefault());
			ID = Movie.imdbID;
			Titulo = Movie.Title;
			Imagem = Movie.Poster;
		}
	}
}
