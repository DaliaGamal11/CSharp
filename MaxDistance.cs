using System.Xml.Linq;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 0 , max=0; //n:size of the array 
            Console.WriteLine("Enter number of values :");
            N=int.Parse(Console.ReadLine());
            int[] dis = new int[N];
            Console.WriteLine("Enter the values :");
            for (int i = 0; i < N; i++)
            {
                dis[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (dis[i] == dis[j])
                    {
                        
                        int d = j - i - 1; //d:distance , max:max distance
                        if (d > max)
                        {
                            max= d;
                        }
                    }
                }
            }

            Console.WriteLine($"The longest distance between two equal cells is: {max}");
        



}
    }
}
