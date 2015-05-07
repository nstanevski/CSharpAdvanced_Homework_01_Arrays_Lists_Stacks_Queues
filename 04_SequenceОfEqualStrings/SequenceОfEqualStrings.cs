using System;

/*
 * Write a program that reads an array of strings and finds in it all sequences 
 * of equal elements (comparison should be case-insensitive). 
 * The input strings are given as a single line, separated by a space. 
*/
class SequenceОfEqualStrings
{
    static void Main()
    {
        string[] stringArr = Console.ReadLine().Split();

        for (int i = 0; i < stringArr.Length - 1; i++)
        {
            Console.Write("{0} ", stringArr[i]);
            if(!stringArr[i].Equals(stringArr[i+1])){
                Console.WriteLine();
            }
        }
        Console.WriteLine(stringArr[stringArr.Length - 1]);
    }
}

