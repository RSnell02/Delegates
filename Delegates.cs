/*
 * Project: Delegates
 * Filename: Delegates.cs
 * Author: R. Snell
 * Date: 12/21/2020
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Delegates
    {
        // delegate for a function that receives an int and returns a bool
        public delegate bool NumberPredicate(int number);
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 20, 21, 30, 32, 36, 40, 50, 60, 70, 80, 90, 100, 200, 300, 400, 500, 600, 700, 1000 };

            // create an instance of the NumberPredicate elegate type
            NumberPredicate evenPredicate = IsEven;

            // Call IsEven using a delegate variable
            Console.WriteLine(
                $"Call IsEven using a delegate variable : {evenPredicate(4)}");

            // Filter the even numbers using method IsEven
            List<int> evenNumbers = FilterArray(numbers, evenPredicate);

            // Display the result
            DisplayList("\nUse IsEven to filter even numbers: ", evenNumbers);

            // Filter the odd numbers using method IsOdd
            List<int> oddNumbers = FilterArray(numbers, IsOdd);

            // Display the result
            DisplayList("\nUse IsOdd to filter odd numbers: ", oddNumbers);

            // Filter numbers greater than 5 using method IsOver5
            List<int> numbersOver5 = FilterArray(numbers, IsOver5);

            // Display the result
            DisplayList("\nUse IsOver5 to filter numbers over 5: ", numbersOver5);

            // Filter numbers between 5 and 50
            List<int> numbersBetween5and50 = FilterArray(numbers, Between5and50);

            // Display the result
            DisplayList("\nUse Getween5and50 to filter numbers between 5 and 50: ", numbersBetween5and50);

            // Filter numbers that are a multiple of 10
            List<int> numbersMultiple10 = FilterArray(numbers, IsMultiple10);

            // Display the result
            DisplayList("\nUse IsMultiple10 to filter numbers that are a multiple of 10: ", numbersMultiple10);

            // Filter numbers that are not a multiple of 10
            List<int> numbersNot10 = FilterArray(numbers, IsNotMult10);

            // Display the result
            DisplayList("\nUse IsNotMulti10 to filter numbers that are not a multiple of 10: ", numbersNot10);

            // Filter numbers that are a multiple of 3
            List<int> numbersMultiple3 = FilterArray(numbers, IsMultiple3);

            // Display the result
            DisplayList("\nUse IsMultiple3 to filter numbers that are a multiple of 3: ", numbersMultiple3);

            // Filter numbers that are not a multiple of 3
            List<int> numbersNot3 = FilterArray(numbers, IsNotMult3);

            // Display the result
            DisplayList("\nUse IsNotMult3 to filter numbers that are not a multiple of 3: ", numbersNot3);

            // Filter numbers that are a multiple of 100
            List<int> numbersMultiple100 = FilterArray(numbers, IsMultiple100);

            // Display the result
            DisplayList("\nUse IsMultiple100 to filter numbers that are a multiple of 100: ", numbersMultiple100);
            
            // Filter numbers that are not a multiple of 100
            List<int> numbersNot100 = FilterArray(numbers, IsNotMult100);

            // Display the result
            DisplayList("\nUse IsNotMult100 to filter numbers that are not a multiple of 100: ", numbersNot100);
        }   // End Main()

        // Select an array's element that statiesfies the predicate
        private static List<int> FilterArray(int[] intArray, NumberPredicate predicate)
        {
            // Hold the selected elements
            var result = new List<int>();

            // Iterate over each element in the array
            foreach (var item in intArray)
            {
                // If the element satisfies the predicate
                if(predicate(item)) // Invokes method referenced by the predicate
                {
                    result.Add(item);   // Add the element to the result
                }   // End if
            }   // End foreach

            return result; // Returns the result
        }   // End List<>

        // Determine wheather an int is even
        private static bool IsEven(int number) => number % 2 == 0;

        // Determine wheather an int is odd
        private static bool IsOdd(int number) => number % 2 == 1;

        // Determine wheather an int is greater than 5
        private static bool IsOver5(int number) => number > 5;

        // Determine wheather an int is between 5 and 50
        private static bool Between5and50(int number) => number > 5 && number < 50;

        // Determine wheather an int is a multiple of 10
        private static bool IsMultiple10(int number) => number % 10 == 0;

        // Determine wheather an int is not a multiple of 10
        private static bool IsNotMult10(int number) => number % 10 == 1;

        // Determine wheather an int is a multiple of 3
        private static bool IsMultiple3(int number) => number % 3 == 0;

        // Determine wheather an int is not a multiple of 3
        private static bool IsNotMult3(int number) => number % 3 == 1;

        // Determine wheather an int is a multiple of 100
        private static bool IsMultiple100(int number) => number % 100 == 0;

        // Determine wheather an int is not a multiple of 100
        private static bool IsNotMult100(int number) => number % 100 == 1;
        // Display the elements of a list
        private static void DisplayList(string description, List<int> list)
        {
            Console.Write(description); // Display the output's description

            //  Iterate over each element in the List
            foreach (var item in list)
            {
                Console.Write($"{item} ");  // Print item followed by a space
            }

            Console.WriteLine();
        }   // End DisplayList
    }   // End Class
}   //End namespace
