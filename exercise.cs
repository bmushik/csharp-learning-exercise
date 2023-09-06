using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> evenNumbers = new List<int>();

        for (int i = 2; i <= 100; i += 2)
        {
            evenNumbers.Add(i);
        }

        for (int i = 0; i < evenNumbers.Count; i++)
        {
            Console.Write(evenNumbers[i]);

            if ((i + 1) % 5 == 0)
            {
                int sum = 0;
                for (int j = i - 4; j <= i; j++)
                {
                    sum += evenNumbers[j];
                }
                Console.Write("." + " (" + sum + ")\n");
            }
            else
            {
                Console.Write(",");
            }
        }
    }
}
