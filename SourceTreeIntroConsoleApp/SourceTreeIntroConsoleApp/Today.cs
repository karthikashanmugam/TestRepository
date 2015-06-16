using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SourceTreeIntroConsoleApp
{
    class Today
    {
        static void Main()
        {
            // This DateTime is constructed with an instance constructor.
            // ... We write it to the console.
            // ... If this is today, the second line will be True.
            DateTime value = new DateTime(2014, 1, 18);
            Console.WriteLine(value);
            Console.WriteLine(value == DateTime.Today);
        }
    }
}
