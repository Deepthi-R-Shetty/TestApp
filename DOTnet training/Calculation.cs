using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTnet_training
{
	public class Calculation
	{
		public Calculation() { }	
		public int number1 {  get; set; }
		public int number2 { get; set; }
		public void add(int number1,in int number2)
		{
			Console.WriteLine( number1 + number2);
		}
	}
}
