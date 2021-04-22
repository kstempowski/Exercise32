using System;

namespace Exercise32
{
    class Program
    {
        
       
        static void Main(string[] args)
        {
            bool repeat = true;
            while(repeat)
            { 
            //Create an array with 5 numbers (given in the instructions).
            int[] myArray = new int[] { 2, 8, 0, 24, 51 };
            Console.WriteLine("Enter a number to find its index in the array");
            string val = Console.ReadLine();
            int index = int.Parse(val);

            //This will create a "list" of the 5 numbers and their indexes in memory.
            int number = Array.IndexOf(myArray, index);

                if (index == 2 || index == 8 || index == 0|| index == 24 || index == 51)
                {
                    //If the numbers 0,2,8,24, or 51 are given, their index will be returned.
                    Console.WriteLine($"The number {index} is in index {number}");
                }
                else
                {
                    //If the numbers 0,2,8,24, or 51 are NOT given, no index will be found.
                    Console.WriteLine("That index cannot be found.");
                }

                Console.WriteLine("Would you like to search for another index? y/n");
                string answer = Console.ReadLine().ToLower();

                if (answer == "y")
                {
                    //No matter if capital or lower case is used, a Y/y will return bool true
                    repeat = true;
                }
                else
                {
                    //Any answer other than Y/y will return bool false, and the loop will terminate.
                    Console.WriteLine("Goodbye");
                    repeat = false;
                }
            }
        }
    }
}

