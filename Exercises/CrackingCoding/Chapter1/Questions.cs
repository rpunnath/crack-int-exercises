using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    public static class Questions
    {
        public static void HasUniqueCharacters()
        {
            string input;
            do
            {
                Console.WriteLine("Input String");
                input = Console.ReadLine();
                Console.WriteLine("Unique {0}, Continue Y/N?"
                    , StringOperations.AreAllUniqueVersion(input) ? "Yes" : "No");
                input = Console.ReadLine();
            } while (!input.Equals("N", StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
