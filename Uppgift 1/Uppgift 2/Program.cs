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

            int wordcount = 1; //dvs när det första spacet hittas är det ord 2
            foreach (char c in UserResponse)
            {
                if (c == ' ')
                {
                    wordcount++;
                }
            }

            string[] words = new string[10];
            string word = "";
            int i = 0;
            foreach (char c in UserResponse)
            {
                if (c != ' ')
                {
                    word = word + c;
                }
                else
                {
                    words[i] = word;
                    word = "";
                    i++;
                }
                
            }

            Console.WriteLine("Words består av {0} ord", words.Length);
            Console.WriteLine(words);

            foreach (string s in words)
            {
                Console.WriteLine("{0} ({1})", s, s.Length);
            }

        }
    }
}
