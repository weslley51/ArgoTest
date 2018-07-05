using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteArgo.Entities;

namespace TesteArgo.Data
{
	public interface IRepository<T> where T : Dominio
	{
		T GetById(long Id);	
		IEnumerable<T> GetAll();
	}

	public class Repository<T> : IRepository<T> where T : Dominio
	{
		private DbContext Context { get; set; }
		protected DbSet<T> Set;

		public Repository(DbContext Context)
		{
			this.Context = Context;
			Set = Context.Set<T>();
			this.Context.Database.Log = (x => System.Diagnostics.Debug.WriteLine(x));
		}

		public virtual T GetById(long id)
		{
			return Set.Find(id);
		}

		public virtual IEnumerable<T> GetAll()
		{
			return Set.ToList();
		}
	}
}
