using System;
using System.Collections.Generic;

/*
 * Write a program that reads from the console a number N and an array of integers
 * given on a single line. Your task is to find all subsets within the array 
 * which have a sum equal to N and print them on the console 
 * (the order of printing is not important). 
 * Find only the unique subsets by filtering out repeating numbers first. 
 * In case there aren't any subsets with the desired sum, print "No matching subsets."
 */

class SubsetSums
{
    //returns list with positions of digit '1' at the binary
    //representation of number num. Positions are counted from
    //right to left. Rightmost is position 0.
    //Sample: 5 is 101 and the result is [0, 2]
    private static List<int> getOnePositions(int num)
    {
        List<int> result = new List<int>();
        int i = 0;
        while (num > 0)
        {
            if (num % 2 == 1)
                result.Add(i);
            num /= 2;
            i++;
        }
        return result;
    }
    
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        string[] arrStr = Console.ReadLine().Split();

        //filter repeating numbers
        List<int> numbers = new List<int>();  
        foreach(string str in arrStr){
            int num = int.Parse(str);
            if(numbers.IndexOf(num) == -1)
                numbers.Add(num);
        }

        bool found = false;
        int listCount = numbers.Count;

        //number of possible combinations of elements of numbers list:
        int numCombinations = (int)Math.Pow(2,listCount) - 1;
        List<int> indexes;
        
        for(int i=0; i<numCombinations; i++){
            indexes = getOnePositions(i);
            int currentSum = 0;
            foreach (int index in indexes)
                currentSum += numbers[index];
            
            if (currentSum == sum)
            {
                List<int> numbersUsed = new List<int>();
                foreach (int index in indexes)
                    numbersUsed.Add(numbers[index]);

                if (numbersUsed.Count > 0)
                {
                    found = true;
                    Console.WriteLine(string.Join(" + ", numbersUsed) + " = " + sum);
                }
            }
        }
        if (!found)
            Console.WriteLine("No matching subsets.");
    }   
}