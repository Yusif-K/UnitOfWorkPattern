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
	public class StudentService : BaseService<Student>, IStudentService
	{
		private readonly IUnitOfWork unitOfWork;
		private readonly IStudentRepository studentRepository;

		//Konstruktora  arqumentleri Ninject ozu gonderir
		public StudentService(IUnitOfWork unitOfWork, IStudentRepository studentRepository)
		: base(unitOfWork, studentRepository)
		{
			this.unitOfWork = unitOfWork;
			this.studentRepository = studentRepository;
		}

		public void Remove(int studentId)
		{
			studentRepository.Remove(studentId);
		}
	}
}
