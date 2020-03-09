using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods methods = new Methods();

            #region 1. List Practice Example
            //1. Given a list of numbers and a number k, return whether any two numbers from the list add up to k.

            //For example, given[10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.

            //List<int> list = new List<int>() { 10, 15, 3, 7 };
            //list.Sort();

            //Console.WriteLine("Enter a number");
            //int k = Convert.ToInt32(Console.ReadLine());
            //bool awnser = false;
            //int start = 0;
            //int listSize = list.Count - 1;
            //while (start < listSize)
            //{
            //    if (list[start] + list[listSize] == k)
            //    {
            //        awnser = true;
            //        start = 4;
            //    }
            //    else if ((list[start] + list[listSize]) < k)
            //    {
            //        start++;
            //    }
            //    else
            //    {
            //        listSize--;
            //    }
            //}
            //Console.WriteLine(awnser);
            #endregion

            #region 2. Array Practice Example
            // Given an array of ints, write a C# method to total all the values that are even numbers.

            //int[] intArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //int sumMethod = intArray.Sum();

            //int sum = 0;

            //foreach (int num in intArray)
            //{
            //    if (num % 2 == 0)
            //    {
            //        sum += num;
            //    }
            //}

            //Console.WriteLine(sumMethod);
            //Console.WriteLine(sum);
            #endregion

            #region 3. ALTERNATIVE METHOD WITH CUSTOM ARRAY

            //Console.WriteLine("Enter a number for the length of the array");
            //int arrayLength = int.Parse(Console.ReadLine());
            //int[] customArray = new int[arrayLength + 1];

            //for (int i = 0; i <= arrayLength; i++)
            //{
            //    customArray[i] = i;
            //}

            //int sum = 0;

            //foreach (int num in customArray)
            //{
            //    if (num % 2 == 0)
            //    {
            //        sum += num;
            //    }
            //}

            //Console.WriteLine(sum);
            #endregion

            #region 4. Reversing a String 
            //Reverse a String

            string input = "GrandCircus";
            char[] inputArray = input.ToCharArray();
            char[] newArray = new char[inputArray.Length];
            int newSpot = 0;

            for (int i = inputArray.Length - 1; i >= 0; i--)
            {
                newArray[newSpot] = inputArray[i];
                newSpot += 1;
            }

            string output = newArray.ToString();

            Console.WriteLine(output);
            #endregion

            #region 5. Reverse an integer Array

            //Console.WriteLine("Enter a number for the length of the array");
            //int arrayLength = int.Parse(Console.ReadLine());
            //int[] customArray = new int[arrayLength + 1];

            //for (int i = 0; i <= arrayLength; i++)
            //{
            //    customArray[i] = i;
            //}

            //foreach (int num in customArray)
            //{
            //    Console.Write(num);
            //}

            //int[] backwardsIntArray = new int[customArray.Length];
            //int newSpot = 0;

            //for (int i = customArray.Length - 1; i >= 0 ; i--)
            //{
            //    backwardsIntArray[newSpot] = customArray[i];
            //    newSpot += 1;
            //}
            //Console.WriteLine();
            //foreach (int num in backwardsIntArray)
            //{
            //    Console.Write(num);
            //}
            #endregion

            #region 6. Checking a string for a character

            //Find a character if it exists in string, and how many times if it occurs in a string

            //    string again = "y";

            //    while (again == "y")
            //    {
            //        Console.WriteLine("Enter in a string");
            //        string stringInput = Console.ReadLine();
            //        Console.WriteLine("Enter a character you want to search for in the string");
            //        char charInput = Char.Parse(Console.ReadLine());

            //        int match = 0;

            //        match = methods.addChar(stringInput, charInput);

            //        if (match == 0)
            //        {
            //            Console.WriteLine("Does not exist");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"There are {match} matching characters of '{charInput}' in {stringInput}\n");
            //        }

            //        Console.WriteLine("Would you like to continue? (y/n)");
            //        again = Console.ReadLine();
            //        Console.WriteLine();
            //    }

            //    Console.WriteLine("Goodbye");
        }
        #endregion
    }
}


