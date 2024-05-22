using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // Objective: Iterate through a character array. Try to parse each character into an integer.
            // If you attempt to parse a letter into an integer, an exception will occur. 
            // Use a try-catch statement to avoid a run-time exception.
            // Below we will set this up.
            // ------------------------------------------------------------------------------
            var arr = new char[] {'1', '2', '3', '4', '5', '6', 'a', 'b', 'c'};
            var numbers = new List<int>();
            var str = "";

            foreach (var item in arr) 
            {
                try
                {
                    str = item.ToString();
                    var number = int.Parse(str);

                    numbers.Add(number);    
                }
                catch (Exception e) 
                {
                    Console.WriteLine($"Unable to Parse {item}");
                }
            }
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
