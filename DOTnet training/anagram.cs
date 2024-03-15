using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTnet_training
{
	public class anagram
	{

		public void anagramprgram()
		{
			string str1 = "Heater";
			string str2 = "reheat";
			char[] charstr1= str1.ToLower().ToCharArray();
			char[] charstr2= str2.ToLower().ToCharArray();
			Array.Sort(charstr1);
			Array.Sort(charstr2);
			
			string sortedestr1=new string(charstr1);
			string sortedstr2= new string(charstr2);
			if (sortedestr1 == sortedstr2)
				Console.WriteLine("anagram");
			else
				Console.WriteLine("not anagram");

		}
	}
}
