using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkPattern.Domain;

namespace UnitOfWorkPattern.Service.Abstract
{
	public interface IStudentService:IBaseService<Student>
	{
		void Remove(int studentId);
	}
}
