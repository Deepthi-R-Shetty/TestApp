using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTnet_training
{
	public class salaryprocessing
	{

		public int getsalary()
		{
			return 1;
		}

		public  Task<int> getsalaryTask()
		{
			Console.WriteLine(DateTime.Now);
			return Task.FromResult(0);
			Task.Delay(1000);
			Console.WriteLine(DateTime.Now);
		
		}
	}
}
