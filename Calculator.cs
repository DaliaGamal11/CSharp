/*4-display this menu for user
1 - Addition
2 - Sub
3 - Multiplication
4 - Division if num2 == 0-- > cannot divide by zero
5-Exit*/

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, choice, Result;
            Console.WriteLine("Please enter the 2 number :");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("choose what you want to do with the numbers :");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Sub");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("5-Exit");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Result = num1 + num2;
                    Console.WriteLine("The Result is :" + Result);
                    break;
                case 2:
                    Result = num1 - num2;
                    Console.WriteLine("The Result is :" + Result);
                    break;
                case 3:
                    Result = num1 * num2;
                    Console.WriteLine("The Result is :" + Result);
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Sorry cant divided by zero please try again ");
                    }
                    else
                    {
                        Result = num1 / num2;
                        Console.WriteLine("The Result is :" + Result);
                    }
                    break;
                case 5:
                    Console.WriteLine("Thank you for using the program");
                    break;


            }
        }
    }
}
