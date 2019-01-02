using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkPattern.Domain;
using UnitOfWorkPattern.Repository.Abstract;

namespace UnitOfWorkPattern.Repository.Concret
{
	public class BaseRepository<T> : IBaseRepository<T> where T:BaseEntity
	{
		private readonly Context context;
		private readonly DbSet<T> entites;

		public BaseRepository(Context context){
			this.context = context;
			this.entites = context.Set<T>();
		}

		public void Add(T entity)
		{
			entites.Add(entity);
		}
	}
}
