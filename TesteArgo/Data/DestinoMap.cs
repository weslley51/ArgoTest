using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteArgo.Entities;

namespace TesteArgo.Data
{
	public class DestinoMap : EntityTypeConfiguration<Destino>
	{
		public DestinoMap()
		{
			ToTable("Destino");

			Ignore(x => x.Id);

			HasKey(x => x.DestinoId);

			Property(x => x.Nome)
				.IsOptional();

			Property(x => x.Dia)
				.IsOptional();
		}
	}
}
