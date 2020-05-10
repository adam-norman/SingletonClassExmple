using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Singleton.Instance.Print());
            Console.WriteLine(Singleton.Instance.Print()); ;
            Console.WriteLine();
            Singleton.Instance.whatCanIDo();
            Console.WriteLine();
            Singleton.Instance.Examples();
        }
    }
}
