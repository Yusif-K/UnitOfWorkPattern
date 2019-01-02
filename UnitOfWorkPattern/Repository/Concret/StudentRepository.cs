using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkPattern.Domain;
using UnitOfWorkPattern.Repository.Abstract;

namespace UnitOfWorkPattern.Repository.Concret
{
	public class StudentRepository : BaseRepository<Student>, IStudentRepository
	{
		private readonly Context context;

		//Konstruktora  arqumenti Ninject ozu gonderir
		public StudentRepository(Context context) : base(context)
		{
			this.context = context;
		}

		//bu metod Student-e aid olan Teacher-de olmayan bir metoddur
		//Context-ler eyni referansli oldugu ucun Main metodunda silinen Studentler heqiqeten de bazadan silinir
		public void Remove(int studentId)
		{
			context.Students.Remove(context.Students.Find(studentId));
		}
	}
}
