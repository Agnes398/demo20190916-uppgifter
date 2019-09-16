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


            var sortedWords =
            from w in words
            orderby w.Length
            select w;


            foreach (string w in sortedWords)
            {
                Console.WriteLine(w);
            }

            //int x = 0;
            //for (int i = 0; i < words.Length; i++)
            //{
            //    foreach (string s in words)
            //    {
            //        char[] charArray = words[x].ToCharArray();
            //        Array.Reverse(charArray);
            //        Console.WriteLine(charArray);
            //        x++;
            //    }
            //}



            //int x = 0;
            //string[] SortedWords = new string[words.Length];
            //foreach (string a in sortedWords)
            //{
            //    SortedWords[x] = a;
            //}

            //Array.Reverse(SortedWords);

            //foreach (string s in SortedWords)
            //{
            //    Console.WriteLine(s);
            //}

            

            //for (int i = 0; i < words.Length; i++)
            //{
            //    foreach (string s in words)
            //    {
            //        foreach (char baklängesWords in charArray)
            //        {
            //            Console.Write(baklängesWords);
            //            x++;
            //        }
            //    }
            //}

        }
    }
}
