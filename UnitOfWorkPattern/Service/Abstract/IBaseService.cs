using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkPattern.Domain;

namespace UnitOfWorkPattern.Service.Abstract
{
	public interface IBaseService<T> where T : BaseEntity
	{
		void Add(T entity);
	}
}
