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
        string[] arr = Console.ReadLine().Split().OrderBy(a => int.Parse(a)).ToArray();
        int[] numArr = Array.ConvertAll(arr, s => int.Parse(s));
        Console.WriteLine(string.Join(" ", numArr));
    }
}