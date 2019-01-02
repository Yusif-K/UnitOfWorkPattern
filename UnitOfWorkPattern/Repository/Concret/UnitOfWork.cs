using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkPattern.Repository.Abstract;

namespace UnitOfWorkPattern.Repository.Concret
{
	public class UnitOfWork : IUnitOfWork
	{
		private Context context;

		//Konstruktora  arqumenti Ninject ozu gonderir
		public UnitOfWork(Context context)
		{
			this.context = context;
		}

		public int Commit()
		{
			return context.SaveChanges();
		}

		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		private void Dispose(bool dispose)
		{
			if (dispose)
			{
				if (context != null)
				{
					context.Dispose();
					context = null;
				}
			}
		}
	}
}
