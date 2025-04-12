/*Given a list of space separated words, reverse the order of the words. 
[Text Wrapping Break]Input: this is a test		Output: test a is this 
Input: all your base		Output: base your all 
Input: Word			Output: Word 
>> Check the Split Function (Member in String Class) 
Output will be a Single Console.WriteLine Statment  */

namespace Reverse5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inp;
            Console.WriteLine("Please enter the Words u want to reverse :");
            inp = Console.ReadLine();
            string[] words = inp.Split(' ',StringSplitOptions.RemoveEmptyEntries);
            for (int i = words.Length-1; i >= 0; i--)
            {
                Console.Write(words[i]+' ');
            }

        }
    }
}
