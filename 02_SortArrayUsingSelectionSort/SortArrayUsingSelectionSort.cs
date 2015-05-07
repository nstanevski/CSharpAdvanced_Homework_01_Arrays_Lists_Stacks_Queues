using System;
using System.Linq;

class SortArrayUsingSelectionSort
{
    private static void selectionSort(int[] arr)
    {
        int minPos = 0, min = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            min = arr[i];
            minPos = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < min)
                {
                    min = arr[j];
                    minPos = j;
                }
            }
            if (minPos != i)
            {
                int buf = arr[i];
                arr[i] = arr[minPos];
                arr[minPos] = buf;
            }
        }
    }

    static void Main()
    {
        string[] strArr = Console.ReadLine().Split();
        int[] numArr = Array.ConvertAll(strArr, s => int.Parse(s));
        selectionSort(numArr);
        Console.WriteLine(string.Join(" ", numArr));
    }
}