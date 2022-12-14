using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exerise 1:
            // Write a simple C# program to declare a list of integer values,
            // folowed by a simple LINQ query to check fot even numbers,
            // and finally print them to the console.
            // NOTE: You may refer to the sample program we used before for
            //      reference


            // Step 1: Getting data source
            Console.WriteLine("a list of integer values");
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (var number in numbers)
            {
                //if (number%2==0)
                Console.WriteLine(number);
            }
            // Step 2: Writing query
            // Part 1: Data source
            // Part 2: Filter
            // Part 3: Select
            Console.WriteLine("LINQ query to check fot even numbers");
            List<int> inputs = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var query = from i in inputs
                        where i % 2 == 0
                        select i;
            // Step 3: Executing query
            foreach (var i in query)
                Console.WriteLine(i);
        }
    }
}

