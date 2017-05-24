using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        class Person
        {
            int age;
            string name;

            public void SayHi()
            {
                Console.WriteLine("This is a program written in C# that shows just how fast it is.");
                Console.Write("press enter to start the program.");
                Console.ReadLine();
                Bat(repeat);
            }
        }

        static void Bat(string m)
        {
            int repeat = 0;
            int newline = 0;

            do
            {
                if (newline > 5)
                {
                    Console.WriteLine(m + " ");
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
                    Console.Write(m + " ");
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
                Console.WriteLine(" ");
                Console.WriteLine("it just repeated 1,000,000 times.");
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