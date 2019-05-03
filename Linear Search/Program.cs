using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create an array of random ints*/
            int[] nums = new int[100000];
            Random rand = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(100000);
                //Console.Write(nums[i] + " ");
                //if ((i + 1) % 15 == 0)
                    //Console.WriteLine();
            }

            /*Ask the user for a number and search the array for it.*/
            Console.Write("I can check if a number is in the array\nPlease enter a number (0 - 100000): ");
            if (Searching<int>(nums, int.Parse(Console.ReadLine())))
                Console.WriteLine("\nYour number was found in the collection");
            else
                Console.WriteLine("\nYour number wasn't found in the collection");
        }

        /*boolean searching method*/
        static bool Searching<T>(T[] arr, T val)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(val))
                    return true;
            }
            return false;
        }

        /*
        Console.Write("\n\nPlease enter a number to search for: ");
            int input = int.Parse(Console.ReadLine());
            if (FindNum)
                Console.WriteLine("\nWe have found the number " + input + " in the collection...");
            else
                Console.WriteLine("\nWe could not find the number " + input + " in the collection...");

        } */

        /*Method to find the min*/
        //static int FindNum(int[] arr)
        //{
            /*Set the initial min*/
            //int min = arr[0];
            /*Check every subsequent number to see if its lower than the current number*/
            //for (int i = 1; i < arr.Length; i++)
            //{
                /*If the current number is lower, make min equal to the current number*/
              //  if (arr[i] < min)
                //    min = arr[i];
            //}
            /*Return the lowest number in the collection*/
            //return min;
        //}
    }
}
