using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! {0},{1}", DirectLib.Class1.GetValue(), ConflictLib.Class1.GetValue2());

        }
    }
}
