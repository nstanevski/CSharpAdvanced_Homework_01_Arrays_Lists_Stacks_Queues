using System;
using System.Linq;

/*
 * You are given n numbers. Write a program to find among these numbers 
 * all sets of 4 numbers {a, b, c, d}, such that a|b == c|d, where a ≠ b ≠ c ≠ d. 
 * Assume that "a|b" means to append the number b after a. 
 * We call these numbers {a, b, c, d} stuck numbers: 
 * if we append a and b, we get the same result as if we appended c and d. 
 * Note that the numbers a, b, c and d should be distinct (a ≠ b ≠ c ≠ d).
 */
class StuckNumbers
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        int[] numbers = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
        int a=0, b=0, c=0, d=0;
        bool found = false;
        for (int i = 0; i < count; i++)
        {
            for (int j = 0; j < count; j++)
            {
                for (int k = 0; k < count; k++)
                {
                    for (int l = 0; l < count; l++)
                    {
                        if( i!= j && i != k && i != l && j!= k && j != l && k != l)  
                        {
                            a = numbers[i]; b = numbers[j]; c = numbers[k]; d = numbers[l];

                            string s1 = a.ToString() + b.ToString();
                            string s2 = c.ToString() + d.ToString();
                            if (s1.Equals(s2))
                            {
                                Console.WriteLine("{0}|{1}=={2}|{3}", a, b, c, d);
                                found = true;
                            }
                        }
                    }
                }
            }
        }
        if (!found)
            Console.WriteLine("No");
    }
}