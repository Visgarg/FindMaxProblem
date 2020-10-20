﻿using System;

namespace FindMaxProblem
{
    class Program
    {
        /// <summary>
        /// Implementing different methods from different classes
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to find max problem");
            //used to catch exception
            try
            {
                //Calling non generic method to find max of 3 integers
                int maxInt= NonGenericClass.MaxIntegerNumberAmongThree(23, 24, 22);
                Console.WriteLine("max integer value is\t" + maxInt);
                //calling non generic method to find max of 3 floats
                float maxFloat = NonGenericClass.MaxfloatNumberAmongThree(23, 24, 22);
                Console.WriteLine("max float value is\t" + maxFloat);
                //calling non generic method to find max of 3 strings
                string maxString = NonGenericClass.MaxstringNumberAmongThree("23", "24", "22");
                Console.WriteLine("max string value is\t" + maxString);
                //using generic class to print max of 3 numbers
                int maxFromGeneric= GenericClass<int>.MaxAmongThree(23, 45, 555);
                Console.WriteLine("max from generic\t" + maxFromGeneric);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
