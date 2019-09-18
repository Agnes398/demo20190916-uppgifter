using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Var snäll och mata in en mening: ");
            //List<string> ord = new List<string>();
            string userInput = Console.ReadLine();
            string[] ord = userInput.Split(' '); //Dela upp meningen i ord

            foreach (string s in ord)
            {

                char[] charArray = s.ToCharArray();

            }

            //använd Contains för att ta redo om ett annat ord innehåller en bokstav




            for (int i = 0; i < charArray.; i++)
            {
                //userInput = (Console.ReadLine());
                //ord.Add(userInput);

                if (userInput == "AVSLUTA")
                {
                    break;
                }
            }

            //do
            //{

            //    ord.Add(Console.ReadLine());
            //} while ();
            //Console.ReadLine();

        }
    }
}
