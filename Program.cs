using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = new IEnumerableProgram();
                s.method();
            Console.WriteLine("-----------------------------------------------");

            var s1 = new IEnumeratorProgram();
            s1.method1();
           
        }
    }
}
