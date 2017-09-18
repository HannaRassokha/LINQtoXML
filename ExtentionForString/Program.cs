using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtentionForString;

namespace ExtentionForString

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter you string: \n");
            var original = Console.ReadLine().ReverseWords();
            Console.WriteLine("Reversed: {0}", original);
            Console.ReadKey();
        }

    }
}
