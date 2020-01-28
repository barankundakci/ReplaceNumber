using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Works_Study
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            do
            {
                Console.Write("Please give a number as 1st variable: ");
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception e) when (e is FormatException || e is OverflowException)
                {
                    Console.WriteLine("Please enter integer number");
                }
            } while (true);
            do
            {
                Console.Write("Please give a number as 2st variable: ");
                try
                {
                    b = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception e) when (e is FormatException || e is OverflowException)
                {
                    Console.WriteLine("Please enter number");
                }
            } while (true);
            replaceNumber(ref a, ref b);
            Console.WriteLine(String.Format("The value of the 1st variable: {0}",a));
            Console.WriteLine(String.Format("The value of the 2st variable: {0}",b));
            Console.ReadKey();
        }
        public static void replaceNumber(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
    }
}
