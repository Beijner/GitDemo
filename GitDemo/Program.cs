using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            NewMethod("A New World!");

            NewMethod("This is an additional test");


            NewMethod($"{AnAdd(12, 6)}");
        }

        private static void NewMethod(string word)
        {
            Console.WriteLine(word);
        }

        private static int AnAdd(int a, int b) { return a + b; }
    }
}
