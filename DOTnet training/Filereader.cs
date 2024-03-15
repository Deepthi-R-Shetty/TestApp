using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTnet_training
{
	public class Filereader
	{
		public void Reader()
		{
			using (StreamWriter sw = new StreamWriter("C:\\Users\\Deepthi.Shetty\\Documents\\Sample.txt"))
			{
				sw.WriteLine("Deepthi");

			}
			//StreamWriter sw = new StreamWriter("C:\\Users\\Deepthi.Shetty\\Documents\\Sample.txt");
			//sw.WriteLine("Deepthi");
			string readtext = File.ReadAllText("C:\\Users\\Deepthi.Shetty\\Documents\\Sample.txt");
			Console.WriteLine(readtext);

		}
	}
	
		
}
