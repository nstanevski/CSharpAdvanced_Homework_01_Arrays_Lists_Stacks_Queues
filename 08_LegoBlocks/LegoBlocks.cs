using System;
using System.Collections.Generic;
using System.Linq;

class LegoBlocks
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        List<int>[] firstArray = new List<int>[count];
        List<int>[] secondArray = new List<int>[count];
        char[] separators = new char[] { ' ', '\t' };
                
        //fill jagged arrays:
        for (int i = 0; i < count; i++)
        {
            List<int> row = Console.ReadLine().Trim().Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            firstArray[i] = row;
        }
        for (int i = 0; i < count; i++)
        {
            List<int> row = Console.ReadLine().Trim().Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            secondArray[i] = row;
        }

        //reverse second jagged array:
        for (int i = 0; i < count; i++)
        {
            secondArray[i].Reverse();
        }

        //check for fitting
        int firstRowSize = firstArray[0].Count + secondArray[0].Count;
        bool fit = true;
        for (int i = 1; i < count; i++)
        {
            int rowSize = firstArray[i].Count + secondArray[i].Count;
            if (rowSize != firstRowSize)
            {
                fit = false;
                break;
            }
        }
        if (!fit)
        {
            int cellsCount = 0;
            for (int i = 0; i < count; i++)
            {
                cellsCount += firstArray[i].Count;
                cellsCount += secondArray[i].Count;
            }
            Console.WriteLine("The total number of cells is: "+cellsCount);
        }
        else
        {
            for (int i = 0; i < count; i++)
            {
                string rowStr = "[" + string.Join(", ", firstArray[i]) + ", ";
                rowStr += string.Join(", ", secondArray[i]) + "]";
                Console.WriteLine(rowStr);
            }
        }
    }
}