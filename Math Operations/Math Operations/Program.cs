using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Operations
{
    class Program
    {
        static void Main()
        {
            Console.Write("  Give me a number: ");
            double userInput1 = Convert.ToDouble(Console.ReadLine());
            double output1 = userInput1 * 50;
            Console.WriteLine("         " + output1 + " is the result of " + userInput1 + " times 50");
            Console.WriteLine("********************");
            Console.WriteLine("");

            Console.Write("  Give me a number: ");
            double userInput2 = Convert.ToDouble(Console.ReadLine());
            double output2 = userInput2 + 25;
            Console.WriteLine("         " + output2 + " is the result of " + userInput2 + " plus 25");
            Console.WriteLine("********************");
            Console.WriteLine("");

            Console.Write("  Give me a number: ");
            double userInput3 = Convert.ToDouble(Console.ReadLine());
            double output3 =userInput3 / 12.5;
            Console.WriteLine("         " + output3 + " is the result of " + userInput3 + " divided by 12.5");
            Console.WriteLine("********************");
            Console.WriteLine("");

            Console.Write("  Give me a number: ");
            double userInput4 = Convert.ToDouble(Console.ReadLine());
            bool isUserGreater50 = userInput4 > 50;
            Console.WriteLine("         " + isUserGreater50 + " is the result of " + userInput4 + " being greater then 50");
            Console.WriteLine("********************");
            Console.WriteLine("");

            Console.Write("  Give me a number: ");
            double userInput5 = Convert.ToDouble(Console.ReadLine());
            double output5 = userInput5 % 7;
            Console.WriteLine("         " + output5 + " is the result of " + userInput5 + " modulus 7");
            Console.WriteLine("********************");
            Console.WriteLine("");
            Console.Read();
        }
    }
}
