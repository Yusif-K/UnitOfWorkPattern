using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWorkPattern.Repository.Abstract
{
	public interface IUnitOfWork:IDisposable
	{
		int Commit();
	}
}
