using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("輸入第一個數字");
			string input = Console.ReadLine();
			Console.WriteLine("輸入第二個數字");
			string input2 = Console.ReadLine();
			int number = Convert.ToInt32(input);
			int number2 = Convert.ToInt32(input2);
			string strresult = "";
			bool isTrue = true;
			for (int i = number; i < number2; i++)
			{
				if (number % 2 == 0)
				{
					isTrue = false;
					break;
				}
			}
			if (isTrue) strresult += number + ",";
			Console.WriteLine(strresult);
			//沒寫出來
		}
	}
}
