using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace parseinput
{
	class Program
	{
		static void Main(string[] args)
		{
			int batman = 0;		// The integer batman is used to determine when to end the script
			int lines = 0;		// The integer lines is used to echo the correct number of iterations to repeated.txt
			int line = 0;		// The integer line is used to determine when the next line of welcomes should start
			string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			Console.WriteLine("only enter numbers!");
			Console.WriteLine(" ");

			Console.Write("enter your age: ");

			string age = Console.ReadLine();
			int ageparsed = Int32.Parse(age);
			Console.Write("enter your money: ");
			string money = Console.ReadLine();
			int moneyparsed = Int32.Parse(money);

			if (ageparsed >= 18 && moneyparsed >= 100)
			{
				do
				{
					using (StreamWriter writer =
                    new StreamWriter(desktop + "\\repeated.txt"))
					if(line >= 25)
					{
						writer.WriteLine(lines);
						Console.WriteLine("Welcome");
						line = 0;
						lines++;
						batman++;
					}
					else
					{
						lines++;
						line++;
						writer.WriteLine(lines);
						Console.Write("Welcome ");
						batman++;
					}
				}
				while (batman <= 50000);
			}
			else if (ageparsed < 18 || moneyparsed < 100)
			{
				Console.WriteLine("You are not old enough or you don't have enough money.");
			}
		}
	}
}