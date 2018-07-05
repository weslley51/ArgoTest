using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteArgo.Utils
{
	/// <summary>
	/// Contém as mensagens de Erro que podem ocorrer
	/// </summary>
	public class Error
	{
		/// <summary>
		/// Mensagem
		/// </summary>
		public string Text { get; set; }

		public Error()
		{

		}

		public Error(string Text)
		{
			this.Text = Text;
		}
	}
}
