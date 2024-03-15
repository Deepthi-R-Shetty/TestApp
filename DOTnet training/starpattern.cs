using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DOTnet_training
{
	public class starpattern
	{
		public void patternprogram()
		{
			int rownumber = 5;
			for(int row=1;row<=rownumber;++row)
			{
				for(int col=1;col<=row;++col)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}

			for (int row = 1; row <= rownumber; ++row)
			{
				for (int col = 1; col <= row; ++col)
				{
					if(row%2 == 0)
					 Console.Write(col);
					else
					 Console.Write("*");
				}
				Console.WriteLine();
			}

			for(int row = 1;row<=rownumber; ++row)
			{
				for( int i=1;i<rownumber-row; ++i)
				{
					Console.Write(" ");
				}
				for(int j=1;j<=row; ++j)
				{
					Console.Write("*");
				}
				Console.WriteLine();


			}

			for (int i = 0; i < rownumber; ++i)
			{
				for (int j = 0; j <= i; ++j)
				{
					Console.Write("*");
				}

				if (i != rownumber - 1)
				{
					Console.Write(" ");
				}
				else
				{
					Console.Write(" * ");
				}
				for (int j = 0; j <= i; ++j)
				{
					Console.Write("*");
				}

				Console.WriteLine();
			}

		}
	}
}
