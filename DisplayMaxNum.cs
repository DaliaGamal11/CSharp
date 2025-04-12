//Take 3 numbers from user and display the max Number
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x ,y ,z , max=0;
            Console.WriteLine("Enter the 3 Nunbers to pick the max please");
            x=int.Parse(Console.ReadLine());
            y=int.Parse(Console.ReadLine());
            z=int.Parse(Console.ReadLine());

            if (x >= y && x >= z)
            {
                max = x;
            }
            else if (y >= x && y >= z)
            {
                max = y;
            }
            else 
            {
                max = z;
            }
            Console.WriteLine("The max Number is " + max);
        }
    }
}
