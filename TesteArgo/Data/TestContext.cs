using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteArgo.Entities;

namespace TesteArgo.Data
{
	public class TestContext : DbContext
	{
		private string ConnectionString { get; set; }
		public virtual DbSet<Destino> Accounts { get; set; }

		public TestContext() : base("ConnectionString")
		{
			Configuration.ProxyCreationEnabled = false;			
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Add<StoreGeneratedIdentityKeyConvention>();

			modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
			modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

			modelBuilder.Configurations.Add(new DestinoMap());

			modelBuilder
				.Properties<string>()
					.Configure(x => x.HasMaxLength(500));

			modelBuilder
				.Properties<string>()
					.Configure(x => x.HasColumnType("nvarchar"));

			modelBuilder
				.Properties<DateTime>()
					.Configure(x => x.HasColumnType("datetime2")
						.HasPrecision(2));

			modelBuilder
				.Properties<int>()
					.Where(x => x.Name.Contains("Id"))
						.Configure(x => x.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity));

		}
	}
}
