using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in en mening: ");
            string mening = Console.ReadLine();
            string[] ord = mening.Split(' '); //Dela upp meningen i ord

            char[] bokstäver = new char[ord.Length];

            foreach (string s in ord)
            {
                s.ToCharArray();

            }

            for (int i = 0; i < ord.Length; i++)
            {


                
            }

        }
    }
}
