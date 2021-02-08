using System;
using System.IO;

namespace StringInterp
{
    class Program
    {
        static void Main(string[] args)
        {
           DateTime today = DateTime.Now;
           double pi = 3.14159265359;
           Console.WriteLine(today.ToString("MMMM dd, yyyy"));//1
           Console.WriteLine(today.ToString("yyyy.MM.dd"));//2
           Console.WriteLine("Day " + today.ToString("dd") + " of " + today.ToString("MMMM, yyyy"));//3
           Console.WriteLine("Year: " + today.ToString("yyyy") + " Month: " + today.ToString("MM") + " Day: " + today.ToString("dd"));//4
           Console.WriteLine("{0,10:dddd}", today);//5
           Console.WriteLine("{0:t} {0,10:dddd}", today); //6
           Console.WriteLine("h:" + today.ToString("hh") + ", m:" + today.ToString("mm") + ", s:" + today.ToString("ss"));//7
           Console.WriteLine(today.ToString("yyyy.MM.dd.hh.mm.ss")); //8

           Console.WriteLine("{0:C2}",pi);
           Console.WriteLine("{0,10:n3}",pi);//10
        }
    }
}
 