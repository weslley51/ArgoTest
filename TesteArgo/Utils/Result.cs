using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteArgo.Utils
{
	/// <summary>
	/// Classe auxiliar que contém o retorno das operações do Sistema, sejam elas erros e/ou um objeto
	/// </summary>
	public class Result<T>
	{
		/// <summary>
		/// Contém os dados do retorno
		/// </summary>
		public T Data { get; set; }

		/// <summary>
		/// Contém uma lista com as mensagens de erro que ocorreram
		/// </summary>
		public List<Error> Errors { get; set; }

		public Result()
		{
			Errors = new List<Error>();
		}

		public Result(T Data)
		{
			this.Data = Data;
		}

		public Result(Error Error, T Data)
		{
			this.Data = Data;
			Errors = new List<Error> { Error };
		}

		public Result(params Error[] Errors)
		{
			this.Errors = new List<Error>();
			this.Errors.AddRange(Errors);
		}

		/// <summary>
		/// Adiciona uma ou mais mensagens de erro
		/// </summary>
		/// <param name="Errors">Mensagens de Erro</param>
		public void AddError(params Error[] Errors)
		{
			if (Errors == null || Errors.Length <= 0)
				return;

			if (this.Errors == null)
				this.Errors = new List<Error>();

			this.Errors.AddRange(Errors);
		}

		/// <summary>
		/// Verifica se existem erros
		/// </summary>
		/// <returns></returns>
		public bool ContainError()
		{
			return Errors != null && Errors.Count > 0;
		}
	}
}
