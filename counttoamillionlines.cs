using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace onemillion
{
    class Program
    {
        class Person
        {
            int age;
            string name;
            int repeat = 0;
            public void SayHi()
            {
                Console.WriteLine("This is a program written in C# that shows just how fast it is.");
                Console.Write("press enter to start the program.");
                Console.ReadLine();
                Bat(repeat);
            }
        }

        static void Bat(int m)
        {
            int repeat = 0;
            int newline = 0;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            do
            {
                if (newline > 5)
                {
                    Console.WriteLine(repeat + " ");
                    newline = 0;
                    repeat++;
                    if (repeat > 1000000)
                    {
                        break;
                    }
                    else;
                    {
                    }
                }
                else
                {
                    Console.Write(repeat + " ");
                    newline++;
                    repeat++;
                    if (repeat > 1000000)
                    {
                        break;
                    }
                    else;
                    {
                    }
                }
            }
            while (repeat <= 1000000);
            if(repeat >= 1000001)
            {
                TimeSpan goneby = stopWatch.Elapsed;
                stopWatch.Stop();
                string time = String.Format("{0:00}:{1:00}.{2:00}",
                    goneby.Minutes, goneby.Seconds,
                    goneby.Milliseconds / 10);
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("It took " + time + " to finish the program");
                Console.WriteLine(" ");
                Console.WriteLine("it just repeated 1,000,000 times.");
                Console.WriteLine("if you think that is slow, why don't you type the numbers 1 - 1,000,000?");
                Console.Write("press enter to exit the program.");
                Console.ReadLine();
            }
        }

        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.SayHi();
        }
    }
}