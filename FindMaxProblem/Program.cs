using System;

namespace FindMaxProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to find max problem");
            try
            {
                int maxInt= NonGenericClass.MaxIntegerNumberAmongThree(23, 24, 22);
                Console.WriteLine("max integer value is\t" + maxInt);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
