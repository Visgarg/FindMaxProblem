using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxProblem
{
    public class NonGenericClass
    {
        public static int MaxIntegerNumberAmongThree(int first, int second, int third)
        {
            Console.WriteLine("Maximum number");
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            if (third.CompareTo(second) > 0 && third.CompareTo(first) > 0)
            {
                return third;
            }
            throw new Exception("All 3 numbers are same");
        }
    }
}
