using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace FindMaxProblem
{
    public class GenericClass<T> where T: IComparable
    {
        public static T MaxAmongThree(T first, T second,T third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
                return first;
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
                return second;
            if (third.CompareTo(second) > 0 && third.CompareTo(first) > 0)
                return third;
            else
            {
                throw new Exception("All 3 numbers are same");
            }
        }
    }
}
