using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTnet_training
{
	public class Palindrome
	{
		public void palindromeprogram()
		{
			string str = "mada";

			char[] arr = str.ToCharArray();
		    Array.Reverse(arr);
			string revstr=new string(arr);
			
			if (str.Equals( revstr))
				Console.WriteLine("palindrome");
			else Console.WriteLine("not palindrome");

			str.Reverse();
			string rev=new string(arr);
			if (str == rev)
				Console.WriteLine("palindrome");
            else
            {
				Console.WriteLine("not palindrome");
            }
			bool s = true;
			
			for(int i = 0; i < str.Length/2; i++)
			{
				if (str[i] != str[str.Length - 1 - i])
					s = false;
					break;

			}
			if (s==true)
			{
				Console.WriteLine("palindrome");
			}
			else { Console.WriteLine("not palindrome"); }

			





        }
		


	}
}
