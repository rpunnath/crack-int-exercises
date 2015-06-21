using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            string question;

            Console.WriteLine("Chapter 1: Pick Question");
            do
            {
                Console.WriteLine("1.1:Algorithm to determine if a string has all unique characters");
                Console.WriteLine("E:Exit?");
                question = Console.ReadLine();

                switch (question)
                {
                    case "1.1":
                        Questions.HasUniqueCharacters();
                        break;
                }
            } while (!question.Equals("E", StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
