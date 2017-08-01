using System;
using System.Collections.Generic;

namespace randoms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using the Random class.
            //generate a list of 20 random numbers that are in the range of 1-50.

            Random random = new Random();

            List<double> randomList = new List<double>();

            for (var i=0; i < 20; i++){
                randomList.Add(random.Next(1, 50));
            }
            
            Console.WriteLine("\nList of Randoms\n");

            foreach ( int i in randomList){
                Console.WriteLine($"{i}");
            }

            // With the resulting List, populate a new List that contains each number squared.
            //For example, if the original list is 2, 5, 3, 15, the final
            // list will be 4, 25, 9, 225.

            List<double> squaredNumbers = new List<double>();

            Console.WriteLine("\nSquared Numbers\n");

            foreach ( double number in randomList){
                double squared = Math.Pow(number, 2);
                squaredNumbers.Add(squared);
                Console.WriteLine(squared);
            }

            Console.WriteLine("\nRemove Odd Numbers\n");
            foreach (var num in squaredNumbers){
                if (num % 2 == 0){
                    Console.WriteLine(num);
                }
            }


        }
    }
}
