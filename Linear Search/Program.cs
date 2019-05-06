using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("***************************************************");
        Console.WriteLine("*************** Searching Algorithm ***************");
        Console.WriteLine("***************************************************\n");
        /*Create an array of random ints*/
        int[] nums = new int[100000];
        Random rand = new Random();
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = rand.Next(10000);
        }

        /*Ask the user for a number and search the array for it.*/
        Console.Write("I can check if a number is in the array\nPlease enter a number (0 - 10000): ");
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
}