using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Write a program that reads N floating-point numbers from the console. 
 * Your task is to separate them in two sets, one containing only the round numbers 
 * (e.g. 1, 1.00, etc.) and the other containing the floating-point numbers 
 * with non-zero fraction. Print both arrays along with their minimum, maximum, 
 * sum and average (rounded to two decimal places).
 */

class CategorizeNumbers
{
    static void Main()
    {
        string[] strArr = Console.ReadLine().Split();
        double[] doubleArr = Array.ConvertAll(strArr, s => double.Parse(s));
        const double EPS = 1e-14;

        List<double> doubleList = new List<double>();
        List<int> intList = new List<int>();

        foreach (double item  in doubleArr)
	    {
            if(Math.Abs(item - (int) item) <= EPS)
            {
                intList.Add((int) item);
            }
            else
            {
                doubleList.Add(item);
            }
	    }

        double doubleMin = doubleList.Min();
        double doubleMax = doubleList.Max();
        double doubleSum = doubleList.Sum();
        double doubleAvg = doubleList.Average();
        string doubleListStr = "[" + string.Join(", ", doubleList) + "]";

        int intMin = intList.Min();
        int intMax = intList.Max();
        int intSum = intList.Sum();
        double intAvg = intList.Average();
        string intListStr = "[" + string.Join(", ", intList)+"]";

        Console.WriteLine("{0} -> min: {1:#.###}, max: {2:#.###}, sum: {3:#.###}, avg: {4:#.###}",
            doubleListStr, doubleMin, doubleMax, doubleSum, doubleAvg);
        Console.WriteLine("{0} -> min: {1}, max: {2}, sum: {3}, avg: {4:#.###}",
            intListStr, intMin, intMax, intSum, intAvg);
        
    }
}