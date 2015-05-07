using System;
using System.Collections.Generic;

/*
 * Write a program to find all increasing sequences inside an array of integers. 
 * The integers are given on a single line, separated by a space. 
 * Print the sequences in the order of their appearance in the input array, 
 * each at a single line. Separate the sequence elements by a space. 
 * Find also the longest increasing sequence and print it at the last line. 
 * If several sequences have the same longest length, print the left-most of them.
 */

class LongestIncreasingSequence
{
    static void Main()
    {
        string[] strArr = Console.ReadLine().Split();
        int[] numArr = Array.ConvertAll(strArr, s => int.Parse(s));

        List<List<int>> sequencesList = new List<List<int>>();
        List<int> sequence = new List<int>();

        //build the list of lists of increasing sequences
        for (int i = 0; i < numArr.Length - 1; i++)
        {
            sequence.Add(numArr[i]);
            if (numArr[i] >= numArr[i + 1])
            {
                sequencesList.Add(sequence);
                sequence = new List<int>();
            }
        }

        //process the last element of the input array
        if (numArr[numArr.Length - 1] > numArr[numArr.Length - 2])
        {
            sequence.Add(numArr[numArr.Length - 1]);
            sequencesList.Add(sequence);
        }
        else
        {
            if(sequence.Count >0)
                sequencesList.Add(sequence);
            sequence = new List<int>();
            sequence.Add(numArr[numArr.Length - 1]);
            sequencesList.Add(sequence);
        }

        int maxCount = 0, maxIndex = 0;
        //print the sequences
        foreach (List<int> seq in sequencesList)
        {
            if (seq.Count > maxCount)
            {
                maxCount = seq.Count;
                maxIndex = sequencesList.IndexOf(seq);
            }
            Console.WriteLine(string.Join(" ", seq));
        }

        //print the longest sequence
        List<int> longestSeq = sequencesList[maxIndex];
        Console.WriteLine("Longest: " + string.Join(" ", longestSeq));
    }
}