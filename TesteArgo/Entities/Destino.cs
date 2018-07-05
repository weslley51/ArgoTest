using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteArgo.Entities
{
	public class Destino : Dominio
	{
		/// <summary>
		/// Destiny Id
		/// </summary>
		public int DestinoId { get { return Id; } set { Id = value; } }

		/// <summary>
		/// Name
		/// </summary>
		public string Nome { get; set; }

		/// <summary>
		/// Day
		/// </summary>
		public DateTime? Dia { get; set; }
	}
}
