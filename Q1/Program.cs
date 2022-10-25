using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("輸入數字");
			string input = Console.ReadLine();
			int number = Convert.ToInt32(input);
			bool isTrue = true;
			for (int i = 2; i < number; i++)
			{
				if (number % i == 0)
				{
					isTrue = false;
					break;
				}
			}
			if (isTrue == true)
			{
				Console.WriteLine(number + "是質數");
			}
			else
			{
				Console.WriteLine(number + "不是質數");
			}
		}
	}
}
