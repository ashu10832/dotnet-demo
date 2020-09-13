using System;
using firstlibrary;

namespace FirstcoreProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var cal = new firstlibrary.Calculator();
            System.Console.WriteLine(cal.add(2,3));
        }
    }
}
