using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentance: ");
            string UserResponse = Console.ReadLine();


            string[] words = UserResponse.Split(' ');

            Console.WriteLine("Words består av {0} ord", words.Length);

            foreach (string s in words)
            {
                Console.WriteLine("{0} ({1})", s, s.Length);
            }

            

        }
    }
}
