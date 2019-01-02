using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkPattern.Domain;
using UnitOfWorkPattern.Repository.Abstract;
using UnitOfWorkPattern.Service.Abstract;

namespace UnitOfWorkPattern.Service.Concret
{
	public class BaseService<T> : IBaseService<T> where T:BaseEntity
	{
		private readonly IUnitOfWork unitOfWork;
		private readonly IBaseRepository<T> baseRepository;

		//Konstruktora  arqumentleri Ninject ozu gonderir
		public BaseService(IUnitOfWork unitOfWork,IBaseRepository<T> baseRepository)
		{
			this.unitOfWork = unitOfWork;
			this.baseRepository = baseRepository;
		}

		public void Add(T entity)
		{
			baseRepository.Add(entity);
		}
	}
}
