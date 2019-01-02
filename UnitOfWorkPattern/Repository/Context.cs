using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkPattern.Domain;

namespace UnitOfWorkPattern.Repository
{
	public class Context : DbContext
	{
		public Context() : base("context")
		{

		}

		public DbSet<Teacher> Teachers { get; set; }
		public DbSet<Student> Students { get; set; }
	}
}
