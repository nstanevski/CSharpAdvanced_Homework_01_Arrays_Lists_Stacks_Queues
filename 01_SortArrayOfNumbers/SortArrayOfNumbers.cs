using System;
using System.Linq;

/*
 *Write a program to sort an array of numbers and then print them back on the console. 
 *The numbers should be entered from the console on a single line, separated by a space.
 */

class SortArrayOfNumbers
{
    static void Main()
    {
        int[] numArr = Console.ReadLine().Trim().Split().Select(p => int.Parse(p)).OrderBy(p => p).ToArray();
        Console.WriteLine(string.Join(" ", numArr));
    }
}