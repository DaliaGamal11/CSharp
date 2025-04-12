/*How can you count the occurrence of 1 from 1 to 99,999,999 (1 short of 100 million) and total up how many 1s were there.
 
(Convert Numbers to String in Case one and use String Functions to Count 1s,  
Use Only Mathematical Functions and Numeric values in case 2 and see the difference in performance)  
Is There Any Other Way to Do it in Approximately 1 Second or less */

namespace Occerrence6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Count = 0;

            for (int i = 1; i <= 99999999; i++)
            {
                Count += CountOnesInString(i.ToString());
            }

            Console.WriteLine($"Total count of '1's : {Count}");
        }

        
        static int CountOnesInString(string numberString)
        {
            int count = 0;
            foreach (char c in numberString)
            {
                if (c == '1')
                {
                    count++;
                }
            }
            return count;
        }
    }

}





class Program2
{
    static void Main()
    {
 
        int Count = 0;
        for (int i = 1; i <= 99999999; i++)
        {
            Count += CountOnesInNumber(i);
        }
        Console.WriteLine($"Total count of '1's : {Count}");
    }

    static int CountOnesInNumber(int number)
    {
        int count = 0;
        while (number > 0)
        {
            if (number % 10 == 1) // Check the last digit
            {
                count++;
            }
            number /= 10; // Remove the last digit
        }
        return count;
    }
}
