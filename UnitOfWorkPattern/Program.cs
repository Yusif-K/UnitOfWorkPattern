using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkPattern.Domain;
using UnitOfWorkPattern.Repository;
using UnitOfWorkPattern.Repository.Abstract;
using UnitOfWorkPattern.Repository.Concret;
using UnitOfWorkPattern.Service.Abstract;
using UnitOfWorkPattern.Service.Concret;

namespace UnitOfWorkPattern
{
	class DataAccess
	{
		static void Main(string[] args)
		{
			var kernel = new StandardKernel();
			kernel.Load(Assembly.GetExecutingAssembly());

			var unitOfWork = kernel.Get<IUnitOfWork>();
			var teacherService = kernel.Get<ITeacherService>();
			var studentSevice = kernel.Get<IStudentService>();

			for (int i = 1; i <= 10; i++)
			{
				teacherService.Add(new Teacher
				{
					TeacherName = "Teacher Name " + i
				});

				studentSevice.Add(new Student
				{
					StudentName = "Student Name " + i
				});
			}
			Console.WriteLine("Əlavə edildi: " + unitOfWork.Commit());

			//proqrami ikinci defe run edende gonderilen 1,9,5 qiymetlerini deyismek lazimdir,
			//cunki ikinci defe run edende hemin id-li Student-ler bazada olmaya biler
			studentSevice.Remove(1);
			studentSevice.Remove(9);
			studentSevice.Remove(5);

			Console.WriteLine("Silindi: " + unitOfWork.Commit());

			Console.ReadLine();
		}
	}

	public class Bindings : NinjectModule
	{
		public override void Load()
		{
			//Demeli proqram isleyende .InScope(x => x.Kernel); sayesinde dbContext birdene olacaq ona gore de tranzaksiyalar duz isleyecek
			//UnitOfWork ve diger repositoryler bu eyni referansli contexden istifade edecekler
			Bind<Context>().To<Context>().InScope(x => x.Kernel);

			Bind<IUnitOfWork>().To<UnitOfWork>();

			Bind<IStudentRepository>().To<StudentRepository>();
			Bind<ITeacherRepository>().To<TeacherRepository>();

			Bind<IStudentService>().To<StudentService>();
			Bind<ITeacherService>().To<TeacherService>();
		}
	}
}
