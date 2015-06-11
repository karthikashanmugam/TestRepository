using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SourceTreeIntroConsoleApp
{
    class Addition
    {
        public static void parameter(int num1, int num2, out int add)
        {
            add = num1 + num2;
        }
        static void Main(string[] args)
        {
            int num1, num2;
            int add;
            Console.Write("Enter 1st number\t");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter 2nd number\t");
            num2 = Convert.ToInt32(Console.ReadLine());

            Addition.parameter(num1, num2, out add);
            Console.WriteLine("\n\n{0} + {1} = {2}", num1, num2, add);

            Console.ReadLine();
        }
    }
}
