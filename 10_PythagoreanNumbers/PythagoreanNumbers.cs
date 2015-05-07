using System;

class PythagoreanNumbers
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        int[] numArr = new int[count];
        for (int n = 0; n < count; n++)
            numArr[n] = int.Parse(Console.ReadLine());
        bool found = false;

             
        for (int i = 0; i < count; i++)
        {
            for (int j = 0; j < count; j++)
            {
                for (int k = 0; k < count; k++)
                {  
                    if (numArr[i] * numArr[i] + numArr[j] * numArr[j] == numArr[k] * numArr[k]
                        &&
                        numArr [i] <= numArr[j]
                        )
                    {
                        found = true;
                        Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", numArr[i], numArr[j], numArr[k]);
                    }          
                }
            }
        }

        if (!found)
            Console.WriteLine("No");
    }
}