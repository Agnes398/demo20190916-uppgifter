using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a line of text: ");
            String userResponse = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Thank you for entering: '{0}' ", userResponse);
        }
    }
}
