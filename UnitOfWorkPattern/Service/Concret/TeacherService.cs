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
	public class TeacherService : BaseService<Teacher>, ITeacherService
	{
		private readonly IUnitOfWork unitOfWork;
		private readonly ITeacherRepository teacherRepository;

		//Konstruktora  arqumentleri Ninject ozu gonderir
		public TeacherService(IUnitOfWork unitOfWork,ITeacherRepository teacherRepository)
		:base(unitOfWork,teacherRepository)
		{
			this.unitOfWork = unitOfWork;
			this.teacherRepository = teacherRepository;
		}
	}
}
