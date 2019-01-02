using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkPattern.Domain;
using UnitOfWorkPattern.Repository.Abstract;

namespace UnitOfWorkPattern.Repository.Concret
{
	public class TeacherRepository : BaseRepository<Teacher>, ITeacherRepository
	{
		private readonly Context context;

		//Konstruktora  arqumenti Ninject ozu gonderir
		public TeacherRepository(Context context) : base(context)
		{
			this.context = context;
		}
	}
}
