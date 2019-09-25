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


            //Stroleksordning på ord från inmatad mening - Uppgift 2.1
            var sortedWords =
            from w in words
            orderby w.Length
            select w;


            foreach (string w in sortedWords)
            {
                Console.WriteLine("{0} ({1})", w, w.Length);
            }


            //Bakvänd storleksorning på ord från inmatad mening - 2.2
            var ReverseOrder =
            from word in words
            orderby word.Length descending
            select word;


            foreach (string word in ReverseOrder)
            {
                Console.WriteLine(word);
            }


            //Skriv ut varje ord baklänges - 2.2 <3
            int x = 0;
            for (int i = 0; i < words.Length; i++)
            {
                foreach (string s in words)
                {
                    char[] chararray = words[x].ToCharArray();
                    Array.Reverse(chararray);
                    Console.WriteLine(chararray);
                    x++;
                }
            }

        }
    }
}
