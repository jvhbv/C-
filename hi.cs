using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace hi
{
	class Program
	{
		static void Main(string[] args)
		{
			string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			int done = 0;
			string lines = "::hello batch";
			do
			{
				using (StreamWriter writer =
				new StreamWriter(desktop + "\\hello.txt"))
				writer.Write(lines + "\r\n");
				Console.WriteLine("hello");
				done++;
			}
			while(done <= 100000);
		}
	}
}